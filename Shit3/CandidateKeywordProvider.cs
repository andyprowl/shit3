using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shit3
{
    class CandidateKeywordProvider
    {
        private List<string> candidateKeywords;
        private string obfuscator;

        public CandidateKeywordProvider(string filename, string obfuscator)
        {
            this.obfuscator = obfuscator;

            var words = System.IO.File.ReadLines(filename);

            this.candidateKeywords = words.Where(s => IsViableKeyword(s)).Select(s => s.ToUpper()).ToList();
        }

        public List<string> CandidateKeywords
        {
            get
            {
                return new List<string>(this.candidateKeywords);
            }
        }

        private bool IsViableKeyword(string s)
        {
            var keyword = s.ToUpper();

            if (keyword.Length != this.obfuscator.Length)
            {
                return false;
            }

            for (var i = 0; i < this.obfuscator.Length; ++i)
            {
                if (keyword[i] == this.obfuscator[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
