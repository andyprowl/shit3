using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shit3
{
    struct Position
    {
        public int row;
        public int col;

        public Position(int r, int c)
        {
            this.row = r;
            this.col = c;
        }

        public Position Next(Direction dir)
        {
            switch (dir)
            {
                case Direction.Up:
                    {
                        return new Position(this.row - 1, this.col);
                    }

                case Direction.Left:
                    {
                        return new Position(this.row, this.col - 1);
                    }

                case Direction.Down:
                    {
                        return new Position(this.row + 1, this.col);
                    }

                default:
                case Direction.Right:
                    {
                        return new Position(this.row, this.col + 1);
                    }
            }
        }

        public override bool Equals(object other)
        {
            var rhs = (Position)other;

            return (row == rhs.row) && (col == rhs.col);
        }

        public override int GetHashCode()
        {
            return (row.GetHashCode() ^ col.GetHashCode());
        }

        public static bool operator ==(Position lhs, Position rhs)
        {
            return (lhs.row == rhs.row) && (lhs.col == rhs.col);
        }

        public static bool operator !=(Position lhs, Position rhs)
        {
            return !(lhs == rhs);
        }
    }
}
