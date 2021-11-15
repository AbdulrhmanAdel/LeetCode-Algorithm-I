namespace Algorithm_I.Day2
{
    public class RotateArrayProblem
    {
        public static void Run(int[] nums, int k)
        {
            var sq = new RotateArrayProblem();
            sq.Rotate(nums, k);
        }
        
        public void Rotate(int[] nums, int k)
        {
            if (k % nums.Length == 0) return;
            
            while (k > nums.Length)
            {
                k -= nums.Length;
            }

            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);
        }

        private void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                var tmp = nums[start];
                nums[start] = nums[end];
                nums[end] = tmp;
                start++;
                end--;
            }
        }
    }
}