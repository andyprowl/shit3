using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shit3
{
    class KeywordNotEncodableException : Exception
    {
    }

    class KeywordEncoder
    {
        public List<int> EncodeKeyword(string text, string keyword)
        {
            var positions = new List<int>();
            positions.Add(0);

            for (var i = 0; i < keyword.Length; ++i)
            {
                var index = text.IndexOf(keyword[i], positions.Last() + 1);
                while ((index >= 0) && (index - positions.Last() < 6))
                {
                    index = text.IndexOf(keyword[i], index + 1);
                }

                if (index < 0)
                {
                    throw new KeywordNotEncodableException();
                }
                else
                {
                    positions.Add(index);
                }
            }

            return positions.Skip(1).ToList();
        }
    }
}
