using System;

namespace Algorithm_I.Day1
{
    /*
        Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. 
        If target exists, then return its index. Otherwise, return -1.
        You must write an algorithm with O(log n) runtime complexity.
     */
    public class BinarySearch
    {
        private int _target;

        public int Search(int[] nums, int target)
        {
            _target = target;
            return Search(nums, 0, nums.Length - 1);
            return Search(nums);
        }

        /// <summary>
        /// Recursion Way
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private int Search(int[] nums, int start, int end)
        {
            if (end < 0) return -1;
            if (start >= end)
            {
                return nums[end] == _target ? end : -1;
            }

            var mid = (start + end) / 2;

            if (nums[mid] == _target)
            {
                return mid;
            }

            if (nums[mid] > _target)
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }

            return Search(nums, start, end);
        }


        /// <summary>
        /// Iterative Way
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        private int Search(int[] nums)
        {
            var start = 0;
            var end = nums.Length - 1;
            while (true)
            {
                if (end < 0) return -1;
                if (start >= end)
                {
                    return nums[end] == _target ? end : -1;
                }

                var mid = (start + end) / 2;

                if (nums[mid] == _target)
                {
                    return mid;
                }

                if (nums[mid] > _target)
                {
                    end = mid - 1;
                    continue;
                }

                start += 1;
            }
        }
    }
}