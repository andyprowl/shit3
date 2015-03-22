using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shit3
{
    class NoKeywordForSentenceException : Exception
    {
    }

    class HostSentenceGenerator
    {
        SentenceProvider sentenceProvider = new OnlineSentenceProvider();
        CandidateKeywordProvider keywordProvider = new CandidateKeywordProvider("words.txt", "SHIT");
        KeywordEncoder encoder = new KeywordEncoder();
        Randomizer randomizer = new Randomizer();

        public HostSentence GenerateSentence(string wordOfChoice)
        {
            while (true)
            {
                var sentence = this.sentenceProvider.GetSentenceContainingWord(wordOfChoice);

                var normalizedSentence = NormalizeSentence(sentence);

                try
                {
                    var positions = PickKeywordForSentence(normalizedSentence);

                    return new HostSentence(sentence, normalizedSentence, positions);
                }
                catch (NoKeywordForSentenceException)
                {
                }
            }
        }

        private string NormalizeSentence(string text)
        {
            text = text.Replace(" ", "");

            text = text.Replace(".", "");

            text = text.ToUpper();

            return text;
        }

        private List<int> PickKeywordForSentence(string text)
        {
            for (var i = 0; i < 20; ++i)
            {
                try
                {
                    var keyword = this.randomizer.PickElementFromCollection(this.keywordProvider.CandidateKeywords);

                    return this.encoder.EncodeKeyword(text, keyword);
                }
                catch (Exception)
                {
                }
            }

            throw new NoKeywordForSentenceException();
        }
    }
}
