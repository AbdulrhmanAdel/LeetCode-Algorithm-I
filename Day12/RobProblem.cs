using System;
using Algorithm_I.Day7;

namespace Algorithm_I.Day12
{
    public class RobProblem
    {
        /*
         * You are a professional robber planning to rob houses along a street.
         * Each house has a certain amount of money stashed,
         * the only constraint stopping you from robbing each of them is
         * that adjacent houses have security systems connected and it will automatically contact the police if two adjacent houses were broken into on the same night.
         * Given an integer array nums representing the amount of money of each house,
         * return the maximum amount of money you can rob tonight without alerting the police.
         */
        public int Rob(int[] nums)
        {
            // Memorize Previous Robbing in 2 pointers
            if (nums.Length == 0) return 0;
            var prev1 = 0;
            var prev2 = 0;
            foreach (var num in nums) {
                var tmp = prev1;
                prev1 = Math.Max(prev2 + num, prev1);
                prev2 = tmp;
            }
            return prev1;
            // Memorize Previous Robbing in array
            if (nums.Length == 0) return 0;
            var memo = new int[nums.Length + 1];
            memo[1] = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                var val = nums[i];
                memo[i + 1] = Math.Max(memo[i], memo[i - 1] + val);
            }

            return memo[nums.Length];
        }
    }
}