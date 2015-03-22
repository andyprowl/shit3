using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shit3
{
    class OnlineSentenceProvider : SentenceProvider
    {
        public string GetSentenceContainingWord(string word)
        {
            while (true)
            {
                try
                {
                    return GetViableSentenceForWord(word);
                }
                catch (Exception)
                {
                }
            }
        }

        string GetViableSentenceForWord(string word)
        {
            var sentences = QueryViableSentencesForWord(word);
            while (sentences.Count() == 0)
            {
                sentences = QueryViableSentencesForWord(word);
            }

            return sentences.First();
        }

        IEnumerable<string> QueryViableSentencesForWord(string word)
        {
            var sentences = FetchAndParseSentencesForWord(word);

            return sentences.Where(s => IsSentenceViable(s));
        }

        bool IsSentenceViable(string s)
        {
            return IsLengthFitting(s) &&
                   ContainsOnlyLettersOrSimplePunctuation(s) &&
                   EndsWithPeriod(s) &&
                   HasNoUppercaseInTheMiddle(s);
        }

        bool HasNoUppercaseInTheMiddle(string s)
        {
            return s.Substring(1).All(c => (!Char.IsLetter(c) || Char.IsLower(c)));
        }

        bool EndsWithPeriod(string s)
        {
            return s.EndsWith(".");
        }

        bool ContainsOnlyLettersOrSimplePunctuation(string s)
        {
            return s.All(c => Char.IsLetter(c) || c == '.' || c == ' ');
        }

        bool IsLengthFitting(string s)
        {
            return (s.Length > 50) && (s.Length < 100);
        }

        IEnumerable<string> FetchAndParseSentencesForWord(string word)
        {
            var html = GetHtmlForWord(word);
            var start = html.IndexOf("<a href");
            while (start >= 0)
            {
                var sentenceStart = html.IndexOf("</b> ", start) + "</b> ".Length;
                var sentenceEnd = html.IndexOf("</p>", sentenceStart) - 1;
                var sentence = html.Substring(sentenceStart, sentenceEnd - sentenceStart);
                yield return sentence;
                start = html.IndexOf("<a href", sentenceEnd);
            }
        }

        string GetHtmlForWord(string word)
        {
            var request = System.Net.WebRequest.Create("http://bnc.bl.uk/saraWeb.php?qy=" + word);
            var response = request.GetResponse();
            var stream = response.GetResponseStream();
            var reader = new System.IO.StreamReader(stream);
            var result = reader.ReadToEnd();
            response.Close();
            return result;
        }
    }
}
