using System;

namespace Algorithm_I.Day14
{
    public class SingleNumberProblem
    {
        /*
         * Given a non-empty array of integers nums,
         * every element appears twice except for one. Find that single one.
         * You must implement a solution with a linear runtime complexity and use only constant extra space.
         */
        public static int Run(int[] nums)
        {
            var problem = new SingleNumberProblem();
            return problem.SingleNumber(nums);
        }
        // ^ XOR 1 ^ 1 = 0 so every number will remove itself and will have the unique one remaining
        public int SingleNumber(int[] nums)
        {
            var result = 0;
            foreach (var num in nums)
            {
                result ^= num;
            }

            return result;
        }
    }
}