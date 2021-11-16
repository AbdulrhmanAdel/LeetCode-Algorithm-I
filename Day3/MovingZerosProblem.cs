namespace Algorithm_I.Day3
{
    public class MovingZerosProblem
    {
        /*
         * Given an integer array nums,
         * move all 0's to the end of it while maintaining the relative order of the non-zero elements.
         * Note that you must do this in-place without making a copy of the array.
         */

        public static void Run(int[] nums)
        {
            var sq = new MovingZerosProblem();
            sq.MoveZeroes(nums);
        }

        public void MoveZeroes(int[] nums)
        {
            if (nums.Length == 0) return; // 1 0 0 6 5 0 0 9

            var nextZeroIndex = -1; // 1
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0) continue;

                nextZeroIndex = i;
                break;
            }
            if (nextZeroIndex == -1) return;
            
            for (var i = nextZeroIndex + 1; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                { // -4,-1,0,0, 0,3,10, 0
                    var tmp = nums[i];
                    nums[i] = nums[nextZeroIndex];
                    nums[nextZeroIndex] = tmp;
                    nextZeroIndex++;
                }
            }
        }
    }
}