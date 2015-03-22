using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shit3
{
    class Randomizer
    {
        Random r = new Random(DateTime.Now.Millisecond);

        public Direction PickDirection()
        {
            return (Direction)r.Next(4);
        }

        public int PickLength(int min, int max)
        {
            return min + r.Next(max - min + 1);
        }

        public Position PickPosition(int maxRow, int maxCol)
        {
            return new Position(r.Next(maxRow), r.Next(maxCol));
        }

        public char PickLetter()
        {
            return (char)((int)'A' + r.Next(26));
        }

        public T PickElementFromCollection<T>(List<T> collection)
        {
            return collection[r.Next(collection.Count())];
        }
    }
}
