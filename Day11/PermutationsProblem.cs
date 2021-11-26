using System.Collections.Generic;

namespace Algorithm_I.Day11
{
    public class PermutationsProblem
    {
        // Given an array nums of distinct integers, return all the possible permutations.
        // You can return the answer in any order.
        public static IList<IList<int>> Run(int[] nums)
        {
            var problem = new PermutationsProblem();
            return problem.Permute(new[] {1, 2, 3});
        }

        private readonly IList<IList<int>> _result = new List<IList<int>>();
        private int[] _nums;
        private bool[] _used;
        public IList<IList<int>> Permute(int[] nums)
        {
            if (nums.Length == 0) return _result;
            _nums = nums;
            _used = new bool[nums.Length];
            Permute(new HashSet<int>());
            return _result;
        }

        /*
         [1, 2, 3]
         Solution Tree
         1     2     3
        2  3  1  3  1  2
        3  2  3  1  2  1
        // More Details On https://algo.monster/problems/permutations#
         */
        private void Permute(ISet<int> p)
        {
            if (p.Count == _nums.Length)
            {
                _result.Add(new List<int>(p));
                return;
            }

            for (var i = 0; i < _nums.Length; i++)
            {
                if (_used[i]) continue;
                p.Add(_nums[i]);
                _used[i] = true;
                Permute(p);
                p.Remove(_nums[i]);
                _used[i] = false;
            }
        }
    }
}