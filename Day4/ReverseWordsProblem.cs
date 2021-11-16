using System.Globalization;
using System.Text;

namespace Algorithm_I.Day4
{
    public class ReverseWordsProblem
    {
        private readonly StringBuilder _builder = new();
        /*
         * Given a string s,
         * reverse the order of characters in each word within a sentence while
         * still preserving whitespace and initial word order.
         */
        
        public static string Run(string word)
        {
            var sq = new ReverseWordsProblem();
            var result = sq.ReverseWords(word);
            return result;
        }
        
        public string ReverseWords(string s)
        {
            var lastCurrentWordIndex = s.Length - 1;
            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ') continue;
                
                lastCurrentWordIndex = i - 1;
                break;
            }
            FillBuilderByReversedWord(s, 0, lastCurrentWordIndex);
            if (lastCurrentWordIndex == s.Length - 1)
            {
                return _builder.ToString();
            }

            _builder.Append(' ');
            for (var i = lastCurrentWordIndex + 2; i < s.Length; i++)
            {
                if (s[i] != ' ') continue;
                
                FillBuilderByReversedWord(s,lastCurrentWordIndex + 2, i - 1);
                _builder.Append(' ');
                lastCurrentWordIndex = i - 1;
            }
            FillBuilderByReversedWord(s, lastCurrentWordIndex + 2, s.Length - 1);
            
            return _builder.ToString();
        }

        private void FillBuilderByReversedWord(string words, int start, int end)
        {
            while (start <= end)
            {
                _builder.Append(words[end]);
                end--;
            }
        }
    }
    
}