using System;
using System.Collections.Generic;

namespace Algorithm_I.Day6
{
    public class LongestSubstringWithoutRepeatingCharsProblem
    {
        /*
         * Given a string s, find the length of the longest substring without repeating characters.
         */
        public static int Run(string s)
        {
            var problem = new LongestSubstringWithoutRepeatingCharsProblem();
            return problem.LengthOfLongestSubstring(s);
        }

        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0) return 0;
            var hash = new Dictionary<char, int>();
            var maxLength = 0;
            for (int start = 0, end = 0; end < s.Length; end++)
            {
                var ch = s[end];  // abcabcbb

                if (hash.ContainsKey(ch))
                {
                    start = Math.Max(start, hash.GetValueOrDefault(ch) + 1);
                }

                hash[ch] = end;
                maxLength = Math.Max(maxLength, end - start + 1);
            }
            return maxLength;
            
        }
        
    }
}