namespace Algorithm_I.Day1
{
    public class SearchInsertProblem
    {
        /*
            Given a sorted array of distinct integers and a target value, return the index if the target is found. 
            If not, return the index where it would be if it were inserted in order.
            You must write an algorithm with O(log n) runtime complexity.
         */
        public int SearchInsert(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            
            var start = 0;
            var end = nums.Length - 1;
            while (start < end)
            {
                var middle = start + (end - start) / 2;
                if (nums[middle] == target)
                {
                    return middle;
                }

                if (nums[middle] > target)
                {
                    end = middle;
                }
                else
                {
                    start = middle + 1;
                }
            }

            return nums[end] >= target ? end : end + 1;
        }
    }
}