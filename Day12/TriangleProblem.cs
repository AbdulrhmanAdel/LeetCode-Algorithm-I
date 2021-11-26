using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Algorithm_I.Day12
{
    public class TriangleProblem
    {
        /*
         * Given a triangle array, return the minimum path sum from top to bottom.
         * For each step, you may move to an adjacent number of the row below.
         * More formally, if you are on index i on the current row,
         * you may move to either index i or index i + 1 on the next row.
         */
        public static int Run(IList<IList<int>> triangle)
        {
            var r = new List<IList<int>>()
            {
                new List<int> {-1},
                new List<int> {2,3},
                new List<int> {1, -1, -3},
                // new List<int> {4, 1, 8, 3}
            };
            var problem = new TriangleProblem();
            return problem.MinimumTotal(r);
        }
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            var mini = triangle[^1];
            for (var i = triangle.Count - 2; i >= 0; --i)
            {
                for (var j = 0; j < triangle[i].Count; ++j)
                {
                    mini[j] = triangle[i][j] + Math.Min(mini[j],mini[j+1]);
                }
            }
            
            return mini[0];
        }
    }
}