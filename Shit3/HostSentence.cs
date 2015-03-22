using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shit3
{
    struct HostSentence
    {
        string sentence;
        string normalizedSentence;
        List<int> keywordPositions;

        public HostSentence(string sentence, string normalizedSentence, List<int> keywordPositions)
        {
            this.sentence = sentence;
            this.normalizedSentence = normalizedSentence;
            this.keywordPositions = keywordPositions;
        }

        public string Sentence
        {
            get
            {
                return sentence;
            }
        }

        public string NormalizedSentence
        {
            get
            {
                return normalizedSentence;
            }
        }

        public string ObfuscatedSentence
        {
            get
            {
                return ComputeObfuscatedSentence();
            }
        }

        public List<int> KeywordPositions
        {
            get
            {
                return new List<int>(keywordPositions);
            }
        }

        public string Keyword
        {
            get
            {
                var keyword = "";
                foreach (var pos in this.keywordPositions)
                {
                    keyword += this.normalizedSentence[pos];
                }

                return keyword;
            }
        }

        string ComputeObfuscatedSentence()
        {
            var obfuscator = "SHIT";

            var obfuscatedSentence = new StringBuilder(this.normalizedSentence);
            for (var i = 0; i < this.keywordPositions.Count(); ++i)
            {
                obfuscatedSentence[this.keywordPositions[i]] = obfuscator[i % obfuscator.Length];
            }

            return obfuscatedSentence.ToString();
        }
    }
}
