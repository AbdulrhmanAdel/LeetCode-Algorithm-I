using System.Collections.Generic;

namespace Algorithm_I.Day6
{
    public class PermutationInStringProblem
    {
        /*
         * Given two strings s1 and s2,
         * return true if s2 contains a permutation of s1,
         * or false otherwise.
         * In other words, return true if one of s1's permutations is the substring of s2.
         */
        public static bool Run(string s1, string s2)
        {
            var problem = new PermutationInStringProblem();
            return problem.CheckInclusion(s1, s2);
        }

        public bool CheckInclusion(string s1, string s2)
        {
            int len1 = s1.Length, len2 = s2.Length;
            if (len1 > len2) return false;

            var count = new int[26];
            // initialize the count for each unique character
            foreach (var c in s1)
            {
                count[c - 'a']++;
            }

            // initialize the sliding window
            int i = 0, j = 0, counter = len1;
            while (j < len1)
            {
                if (count[s2[j++] - 'a']-- > 0)
                {
                    counter--;
                }
            }

            while (j < len2 && counter != 0)
            {
                if (count[s2[i++] - 'a']++ >= 0) counter++;
                if (count[s2[j++] - 'a']-- > 0) counter--;
            }

            return counter == 0;
        }
    }
}