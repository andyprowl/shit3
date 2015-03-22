using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shit3
{
    class ScoreCalculator
    {
        public int Calculate(List<Position> positions)
        {
            var numOfTurns = CountNumberOfTurns(positions);

            return positions.Count() * numOfTurns;
        }

        int CountNumberOfTurns(List<Position> positions)
        {
            var turns = 0;

            for (var i = 0; i < positions.Count() - 2; ++i)
            {
                var dir = ComputeDirection(positions[i], positions[i + 1]);

                if (ComputeDirection(positions[i + 1], positions[i + 2]) != dir)
                {
                    ++turns;
                }
            }

            return turns;
        }

        Direction ComputeDirection(Position from, Position to)
        {
            if (from.Next(Direction.Up) == to) { return Direction.Up; }

            if (from.Next(Direction.Left) == to) { return Direction.Left; }

            if (from.Next(Direction.Down) == to) { return Direction.Down; }

            return Direction.Right;
        }
    }
}
