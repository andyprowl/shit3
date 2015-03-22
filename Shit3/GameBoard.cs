using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shit3
{
    class NoSafeDirectionException : Exception
    {
    }

    class GameBoard
    {
        int size;
        List<char> content = null;
        Randomizer rnd = new Randomizer();

        public GameBoard(int size)
        {
            this.size = size;

            this.content = Enumerable.Repeat(' ', size * size).ToList();

            Clear(true);
        }

        public int Size
        {
            get
            {
                return this.size;
            }
        }

        public char LetterAt(Position pos)
        {
            return content[pos.col * size + pos.row];
        }

        public void Clear(bool fillWithRandomLetters)
        {
            if (fillWithRandomLetters)
            {
                FillTableWithRandomLetters();
            }
            else
            {
                FillWithSpaces();
            }
        }

        public List<Position> PlaceText(string text, int minLegLength, int maxLegLength)
        {
            while (true)
            {
                try
                {
                    return AttemptToPlaceText(text, minLegLength, maxLegLength);
                }
                catch
                {
                    Clear(true);
                }
            }
        }

        public void PlaceText(string word, List<Position> positions)
        {
            for (var i = 0; i < word.Length; ++i)
            {
                FillAt(positions[i], word[i]);
            }
        }

        List<Position> AttemptToPlaceText(string text, int minLegLength, int maxLegLength)
        {
            var occupiedPositions = new List<Position>();
            var pos = PlaceFirstLetter(text, occupiedPositions);

            var dir = Direction.Up;
            while (occupiedPositions.Count() < text.Length)
            {
                dir = PickSafeDirection(pos, occupiedPositions, dir);
                var legLength = PickSafeLegLength(minLegLength, maxLegLength, text, occupiedPositions);
                pos = AdvanceAndFill(pos, dir, legLength, text, occupiedPositions);
            }

            return occupiedPositions;
        }

        int PickSafeLegLength(int minLegLength, int maxLegLength, string text, List<Position> occupiedPositions)
        {
            var minLength = Math.Min(minLegLength + 1, text.Length - occupiedPositions.Count());

            var maxLength = Math.Min(maxLegLength - 1, text.Length - occupiedPositions.Count());

            return rnd.PickLength(minLength, maxLength);
        }

        Position PlaceFirstLetter(string text, List<Position> occupiedPositions)
        {
            var pos = rnd.PickPosition(this.size, this.size);

            FillAt(pos, text[0]);

            occupiedPositions.Add(pos);

            return pos;
        }

        Position AdvanceAndFill(Position pos, Direction dir, int length, string text, List<Position> occupiedPositions)
        {
            for (var i = 0; i < length; ++i)
            {
                if (!IsDirectionSafe(dir, pos, occupiedPositions)) { break; }

                pos = AdvanceAndFill(pos, dir, text[occupiedPositions.Count()], occupiedPositions);
            }

            return pos;
        }

        Position AdvanceAndFill(Position pos, Direction dir, char c, List<Position> occupiedPositions)
        {
            var nextPos = pos.Next(dir);

            FillAt(nextPos, c);

            occupiedPositions.Add(nextPos);

            return nextPos;
        }

        void FillTableWithRandomLetters()
        {
            Fill(() => rnd.PickLetter());
        }

        void FillWithSpaces()
        {
            Fill(() => ' ');
        }

        void Fill(Func<char> filler)
        {
            for (var i = 0; i < this.size; ++i)
            {
                for (var j = 0; j < this.size; ++j)
                {
                    FillAt(new Position(i, j), filler());
                }
            }
        }

        void FillAt(Position p, char c)
        {
            content[p.col * size + p.row] = c;
        }

        bool IsPositionValid(Position pos)
        {
            return (pos.row >= 0) &&
                   (pos.col >= 0) &&
                   (pos.row < this.size) &&
                   (pos.col < this.size);
        }

        bool IsDirectionSafe(Direction dir, Position pos, List<Position> occupiedPositions)
        {
            var nextPos = pos.Next(dir);

            if (!IsPositionValid(nextPos))
            {
                return false;
            }

            return !occupiedPositions.Contains(nextPos);
        }

        Direction PickSafeDirection(Position pos, List<Position> occupiedPositions, Direction lastDirection)
        {
            var triedDirections = new List<Direction>();

            while (triedDirections.Count < 3)
            {
                var dir = rnd.PickDirection();
                if (!triedDirections.Contains(dir) && (dir != lastDirection))
                {
                    if (IsDirectionSafe(dir, pos, occupiedPositions))
                    {
                        return dir;
                    }

                    triedDirections.Add(dir);
                }
            }

            throw new NoSafeDirectionException();
        }
    }
}
