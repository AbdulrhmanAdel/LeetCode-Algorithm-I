using System.Diagnostics.Tracing;

namespace Algorithm_I.Day3
{
    public class TwoSumArrayIIProblem
    {
        /*
         * Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order,
         * find two numbers such that they add up to a specific target number.
         * Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1 < index2 <= numbers.length.
         * Return the indices of the two numbers, index1 and index2, added by one as an integer array [index1, index2] of length 2.
         * The tests are generated such that there is exactly one solution. You may not use the same element twice.
         */
        public static void Run(int[] nums, int target)
        {
            var sq = new TwoSumArrayIIProblem();
            var result = sq.TwoSum(nums, target);
        }

        public int[] TwoSum(int[] numbers, int target)
        {
            var left = 0;
            var right = numbers.Length - 1;

            while (left < right) // 2,7,11,15  9 
            {
                var sum = numbers[left] + numbers[right];

                if (sum == target)
                {
                    return new[] {left + 1, right + 1};
                }

                if (sum > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return null;
        }
    }
}