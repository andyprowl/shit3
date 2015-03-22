using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shit3
{
    public delegate void GameOverEvent(bool result, int score, string message);

    public delegate void TickEvent(int count);

    class GameAlreadyStartedException : Exception
    {
    }

    class GameNotStartedException : Exception
    {
    }

    class BadGameParametersException : Exception
    {
    }

    class Game : IDisposable
    {
        private GameBoard board = new GameBoard(16);
        private HostSentenceGenerator hostSentenceGenerator = new HostSentenceGenerator();
        private Nullable<Challenge> currentChallenge;
        private ScoreCalculator scoreCalculator = new ScoreCalculator();
        private System.Threading.Thread countDownThread = null;
        private volatile bool stopCountDown = false;
        private bool gameStarted = false;

        public event GameOverEvent OnGameOver;

        public event TickEvent OnCountDownTick;

        public Game()
        {
            this.OnGameOver += delegate { }; // So we don't have to check for null before firing.
            
            this.OnCountDownTick += delegate { }; // So we don't have to check for null before firing.
        }

        public Challenge Start(string wordOfChoice, int minLegLength, int maxLegLength, int timeLimit)
        {
            ThrowIfLegLengthBoundsAreInvalid(minLegLength, maxLegLength);

            ThrowIfGameIsAlreadyStarted();

            StopCountDownThread();

            this.gameStarted = true;

            var hostSentence = GenerateHostSentence(wordOfChoice);

            var challenge = PlaceHostSentenceInBoard(hostSentence, minLegLength, maxLegLength);

            StartCountDown(timeLimit);

            return challenge;
        }

        public Challenge Rescramble(int minLegLength, int maxLegLength)
        {
            return PlaceHostSentenceInBoard(this.currentChallenge.Value.HostSentence, minLegLength, maxLegLength);
        }

        public void SubmitSolution(string solution)
        {
            ThrowIfGameIsNotStarted();

            StopCountDownThread();

            VerifySolutionAndFireGameOverEvent(solution);

            this.gameStarted = false;
        }

        public Challenge CurrentChallenge
        {
            get
            {
                return this.currentChallenge.Value;
            }
        }

        public GameBoard ChallengeBoard
        {
            get
            {
                return this.board;
            }
        }

        public GameBoard SolutionBoard
        {
            get
            {
                var solutionBoard = new GameBoard(this.board.Size);

                solutionBoard.Clear(false);

                solutionBoard.PlaceText(this.currentChallenge.Value.HostSentence.ObfuscatedSentence,
                                        this.currentChallenge.Value.Solution);

                return solutionBoard;
            }
        }

        public void Dispose()
        {
            StopCountDownThread();
        }

        private void StopCountDownThread()
        {
            if ((this.countDownThread != null) && (this.gameStarted))
            {
                this.stopCountDown = true;

                this.countDownThread.Abort();
            }
        }

        private void ThrowIfGameIsNotStarted()
        {
            if (!this.gameStarted)
            {
                throw new GameNotStartedException();
            }
        }

        private void ThrowIfGameIsAlreadyStarted()
        {
            if (this.gameStarted)
            {
                throw new GameAlreadyStartedException();
            }
        }

        private void ThrowIfLegLengthBoundsAreInvalid(int minLegLength, int maxLegLength)
        {
            if (maxLegLength < minLegLength)
            {
                throw new BadGameParametersException();
            }
        }

        private void VerifySolutionAndFireGameOverEvent(string solution)
        {
            if (solution == this.currentChallenge.Value.HostSentence.Keyword)
            {
                var score = this.scoreCalculator.Calculate(this.currentChallenge.Value.Solution);

                this.OnGameOver(true, score, "Yeah! U won m8! Ur friend's free! Go have sex now!");
            }
            else
            {
                this.OnGameOver(false, 0, "U failed m8, u suck and ur friend is rekt! HAHAHA!");
            }
        }

        private HostSentence GenerateHostSentence(string wordOfChoice)
        {
            return this.hostSentenceGenerator.GenerateSentence(wordOfChoice);
        }

        private Challenge PlaceHostSentenceInBoard(HostSentence sentence, int minLegLength, int maxLegLength)
        {
            this.board.Clear(true);

            var positionsInBoard = PlaceText(sentence.ObfuscatedSentence, minLegLength, maxLegLength);

            this.currentChallenge = new Challenge(sentence, positionsInBoard);

            return this.currentChallenge.Value;
        }

        private List<Position> PlaceText(string text, int minLegLength, int maxLegLength)
        {
            return this.board.PlaceText(text, minLegLength, maxLegLength);
        }

        private void StartCountDown(int timeLimit)
        {
            if (this.countDownThread != null)
            {
                this.stopCountDown = true;

                this.countDownThread.Join();
            }

            this.stopCountDown = false;

            this.countDownThread = new System.Threading.Thread(() => CountDown(timeLimit));

            this.countDownThread.Start();
        }

        private void CountDown(int countDown)
        {
            this.OnCountDownTick(countDown);

            var numOfWakeups = 0;
            while (countDown > 0 && !this.stopCountDown)
            {
                System.Threading.Thread.Sleep(100);

                ++numOfWakeups;
                if (numOfWakeups % 10 == 0)
                {
                    countDown--;
                    this.OnCountDownTick(countDown);
                }
            }

            ReportGameOverIfCountDownExpired(countDown);
        }

        private void ReportGameOverIfCountDownExpired(int countDown)
        {
            if (countDown == 0)
            {
                this.OnGameOver(false, 0, "Time's out m8, u fookin lose! Say bye to your buddy!");

                this.gameStarted = false;
            }
        }
    }
}
