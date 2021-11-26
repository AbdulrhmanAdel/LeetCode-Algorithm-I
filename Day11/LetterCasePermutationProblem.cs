using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_I.Day11
{
    public class LetterCasePermutationProblem
    {
        /*
         * Given a string s,
         * we can transform every letter individually to be lowercase or uppercase to create another string.
         * Return a list of all possible strings we could create. You can return the output in any order.
         */

        public static IList<string> Run(string source)
        {
            var problem = new LetterCasePermutationProblem();
            return problem.LetterCasePermutation(source);
        }

        private readonly IList<string> _result = new List<string>();
        private char[] _source;

        public IList<string> LetterCasePermutation(string s)
        {
            _source = s.ToCharArray();
            Backtrack(0);
            return _result;
        }

        private void Backtrack(int left)
        {
            if (left == _source.Length)
            {
                _result.Add(new string(_source));
                return;
            }
            
            /*
             check if letter split it to 2 branches if number you have one branch
             Tree
             a1b2         index(1)a      
       a1b2   |   A1b2    check (1 index) 1
       a1b2   |   A1b2    check (index 2)b
    a1b2 a1B2 | A1b2 A1B2 check  (index 3)2
    a1b2 a1B2 | A1b2 A1B2 done;
             */
            if (char.IsNumber(_source[left]))
            {
                Backtrack(left + 1);
                return;
            }
            
            // 
            _source[left] = char.ToUpper(_source[left]);
            Backtrack(left + 1); //Upper case branch
            _source[left] = char.ToLower(_source[left]);
            Backtrack(left + 1); //Lower case branch
        }
    }
}