using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shit3
{
    public partial class MainForm : Form
    {
        private Game game = new Game();

        public MainForm()
        {
            InitializeComponent();

            FillInWordsOfChoice();

            this.FormClosed += (object o, FormClosedEventArgs args) => this.game.Dispose();

            this.game.OnGameOver += (bool success, int score, string message) => OnGameOver(success, score, message);

            this.game.OnCountDownTick += (count) => OnCountDown(count);

            this.textBoxSecondsLeft.Text = "---";

            this.textBoxSecondsLeft.KeyDown += (object sender, KeyEventArgs args) => { HandleKeyDown(args); };

            DisplayWelcomeMessage();
        }

        private void buttonNewChallenge_Click(object sender, EventArgs e)
        {
            DisplayPleaseWaitMessage();

            DisableGameParameterControls();

            var wordOfChoice = this.comboBoxWordsOfChoice.Text;
            var minLegLength = (int)this.numericUpDownMinLegLength.Value;
            var maxLegLength = (int)this.numericUpDownMaxLegLength.Value;
            var timeLimit = (int)this.numericUpDownTimeLimitInSeconds.Value;

            var t = new System.Threading.Thread(() =>
            {
                StartGame(wordOfChoice, minLegLength, maxLegLength, timeLimit);

                this.Invoke((MethodInvoker) delegate
                {
                    UpdateUIControlsAfterGameStart();
                });
            });

            t.Start();
        }

        private void UpdateUIControlsAfterGameStart()
        {
            HideSolution();

            DrawBoard(this.game.ChallengeBoard);

            ResetUserCodeTextBox();

            DisplayFindTheCodeMessage();

            EnableGameActionControls();

            this.textBoxScore.Text = "";
        }

        private void buttonRescramble_Click(object sender, EventArgs e)
        {
            RescrambleBoard();

            DrawBoard(this.game.ChallengeBoard);
        }

        private void buttonSubmitSolution_Click(object sender, EventArgs e)
        {
            this.game.SubmitSolution(this.textBoxUserCode.Text);
        }

        private void buttonGiveUp_Click(object sender, EventArgs e)
        {
            this.game.SubmitSolution("----");
        }

        private void DisplayPleaseWaitMessage()
        {
            this.labelStatus.Text = "Please wait, evil mastermind at work...";
            
            this.labelStatus.ForeColor = Color.Orange;
            
            this.labelStatus.Update();
        }

        private void DisplayFindTheCodeMessage()
        {
            this.labelStatus.ForeColor = Color.Blue;

            this.labelStatus.Text = "Figure out the code and save your friend!";
            
            this.labelStatus.Update();
        }

        private void DisplayWelcomeMessage()
        {
            this.labelStatus.ForeColor = Color.Purple;
            
            this.labelStatus.Text = "Welcome to Shit 3! Enjoy the game and take a load off!";
            
            this.labelStatus.Update();
        }

        private void StartGame(string wordOfChoice, int minLegLength, int maxLegLength, int timeLimit)
        {
            try
            {
                this.game.Start(wordOfChoice, minLegLength, maxLegLength, timeLimit);
            }
            catch (BadGameParametersException)
            {
                MessageBox.Show(this,
                                "Seriously m8? What kind of parameters are those?",
                                "Error",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
        }

        private void RescrambleBoard()
        {
            this.game.Rescramble((int)this.numericUpDownMinLegLength.Value, 
                                 (int)this.numericUpDownMaxLegLength.Value);
        }

        private void FillInWordsOfChoice()
        {
            var words = System.IO.File.ReadLines("words.txt");

            foreach (var w in words)
            {
                this.comboBoxWordsOfChoice.Items.Add(w);
            }

            this.comboBoxWordsOfChoice.Text = "test";
        }

        private void DrawBoard(GameBoard board)
        {
            this.textBoxGameBoard.Text = "";

            for (int i = 0; i < board.Size; ++i)
            {
                for (int j = 0; j < board.Size; ++j)
                {
                    var letter = board.LetterAt(new Position(i, j));

                    this.textBoxGameBoard.Text += letter + ((j < board.Size - 1) ? " " : "");
                }

                this.textBoxGameBoard.Text += (i < board.Size - 1) ? "\r\n" : "";
            }

            this.textBoxGameBoard.Select(0, 0);
        }

        private void ResetUserCodeTextBox()
        {
            this.textBoxUserCode.Text = "----";

            this.textBoxUserCode.Enabled = true;
        }

        private void OnGameOver(bool success, int score, string message)
        {
            this.Invoke((MethodInvoker)delegate
            {
                ShowSolution();

                ShowScore(score);

                this.labelStatus.ForeColor = success ? Color.Green : Color.Red;

                this.labelStatus.Text = message;

                this.labelStatus.Visible = true;

                EnableGameParameterControls();

                DisableGameActionControls();
            });
        }

        private void ShowScore(int score)
        {
            if (score > 1000)
            {
                this.textBoxScore.ForeColor = Color.Green;
                this.labelScoreEvaluation.ForeColor = Color.Green;
                this.labelScoreEvaluation.Text = "Congratulations, awesome score!";
            }
            else if (score > 500)
            {
                this.textBoxScore.ForeColor = Color.Orange;
                this.labelScoreEvaluation.ForeColor = Color.Orange;
                this.labelScoreEvaluation.Text = "Well, that was not bad at all!";
            }
            else if (score > 0)
            {
                this.textBoxScore.ForeColor = Color.DarkOrange;
                this.labelScoreEvaluation.ForeColor = Color.DarkOrange;
                this.labelScoreEvaluation.Text = "Nice, but you can do better...";
            }
            else
            {
                this.textBoxScore.ForeColor = Color.Red;
                this.labelScoreEvaluation.ForeColor = Color.Red;
                this.labelScoreEvaluation.Text = "Nevermind, next time maybe!";
            }

            this.labelScoreEvaluation.Update();

            this.textBoxScore.Text = score.ToString();
        }

        private void OnCountDown(int count)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (count <= 15)
                {
                    this.textBoxSecondsLeft.ForeColor = Color.Red;
                }
                else if (count <= 50)
                {
                    this.textBoxSecondsLeft.ForeColor = Color.Orange;
                }
                else
                {
                    this.textBoxSecondsLeft.ForeColor = Color.Black;
                }

                this.textBoxSecondsLeft.Text = count.ToString();
            });
        }

        void ShowSolution()
        {
            DrawBoard(this.game.SolutionBoard);

            var sentence = this.game.CurrentChallenge.HostSentence;

            SetText(this.textBoxHostSentence, sentence.Sentence);

            SetText(this.textBoxNormalizedSentence, sentence.NormalizedSentence);

            SetText(this.textBoxObfuscatedSentence, sentence.ObfuscatedSentence);
            
            foreach (var pos in sentence.KeywordPositions)
            {
                this.textBoxCode.Text += sentence.NormalizedSentence[pos] + " (" + pos.ToString() + ") ";
            }
        }

        void HideSolution()
        {
            SetText(this.textBoxHostSentence, "");

            SetText(this.textBoxNormalizedSentence, "");

            SetText(this.textBoxObfuscatedSentence, "");

            this.textBoxCode.Text = "";
        }

        void SetText(TextBox textBox, string message)
        {
            textBox.Text = message;

            textBox.Select(0, 0);
        }

        private void DisableGameParameterControls()
        {
            SetGameParameterControlAvailability(false);
        }

        private void EnableGameParameterControls()
        {
            SetGameParameterControlAvailability(true);
        }

        private void DisableGameActionControls()
        {
            SetGameActionControlAvailability(false);
        }

        private void EnableGameActionControls()
        {
            SetGameActionControlAvailability(true);
        }

        private void SetGameParameterControlAvailability(bool enable)
        {
            this.buttonNewChallenge.Enabled = enable;

            this.comboBoxWordsOfChoice.Enabled = enable;

            this.numericUpDownMinLegLength.Enabled = enable;

            this.numericUpDownMaxLegLength.Enabled = enable;

            this.numericUpDownTimeLimitInSeconds.Enabled = enable;
        }

        private void SetGameActionControlAvailability(bool enable)
        {
            this.buttonRescramble.Enabled = enable;

            this.buttonSubmitSolution.Enabled = enable;

            this.buttonGiveUp.Enabled = enable;

            this.textBoxUserCode.Enabled = enable;
        }

        private void HandleKeyDown(KeyEventArgs args)
        {
            if (args.Alt && args.Control && args.Shift && args.KeyCode == Keys.C)
            {
                try
                {
                    MessageBox.Show(this.game.CurrentChallenge.HostSentence.Keyword);
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
