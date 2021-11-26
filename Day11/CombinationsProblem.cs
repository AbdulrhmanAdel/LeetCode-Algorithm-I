using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Algorithm_I.Day11
{
    public class CombinationsProblem
    {
        public static IList<IList<int>> Run(int n, int k)
        {
            var problem = new CombinationsProblem();
            return problem.Combine(n, k);
        }

        public IList<IList<int>> Combine(int n, int k)
        {
            var result = new List<IList<int>>();
            if (n < k) return result;
            var currentCombo = new int[k];

            var j = 0; // i is the index we're looking at in the array "cur"
            while (j >= 0) { // we make sure that i >= 0, if i < 0, go out of the loop
                currentCombo[j]++; // increase cur[i]
                if (currentCombo[j] > n) { // if cur[1] is 5, we can't increase cur[i] anymore [1, 5] , we need to go back to cur[0] and test [2, 3], [2,4]...
                    j--;
                } else if (j == k - 1) { // if we're looking at the last index, we can add it to result
                    result.Add(new List<int>(currentCombo));     
                } else { // look at the next index
                    j++; 
                    currentCombo[j] = currentCombo[j-1];
                }
            }
            return result;
            
            // Recursion Version
            // BackTrack(result, 1, n, k, new List<int>());
            // return result;
        }
        
        private void BackTrack(IList<IList<int>> result, int current, int n, int k, IList<int> currentCombination)
        {
            if (k == 0)
            {
                result.Add(currentCombination);
                return;
            }

            if (current <= n - k)
            {
                BackTrack(result, current + 1, n, k, currentCombination);
            }
            currentCombination.Add(current);
            BackTrack(result, current + 1, n, k, currentCombination);
        }
    }
}