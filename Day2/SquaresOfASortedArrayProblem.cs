using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Algorithm_I.Day2
{
    public class SquaresOfASortedArrayProblem
    {
        public static void Run(int[] nums)
        {
            var sq = new SquaresOfASortedArrayProblem();
            sq.SortedSquares(nums);
        }
        public int[] SortedSquares(int[] nums)
        {
            var lenght = nums.Length;
            var result = new int[lenght];
            var left = 0;
            var right = lenght - 1;
            for (int i = lenght - 1; i >= 0; i--)
            {
                int current;

                if (Math.Abs(nums[left]) >= Math.Abs(nums[right]))
                {
                    current = nums[left];
                    left++;
                }
                else
                {
                    current = nums[right];
                    right--;
                }

                result[i] = current * current;
            }

            return result;
        }
    }
}