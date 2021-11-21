using System.Collections.Generic;

namespace Algorithm_I.Day9
{
    public class RottingOrangesProblem
    {
        /*
         * You are given an m x n grid where each cell can have one of three values:
         * 0 representing an empty cell,
         * 1 representing a fresh orange, or
         * 2 representing a rotten orange.
         * Every minute, any fresh orange that is 4-directionally adjacent to a rotten orange becomes rotten.
         * Return the minimum number of minutes that must elapse until no cell has a fresh orange. If this is impossible, return -1;
         */
        public static int Run(int[][] grid)
        {
            var problem = new RottingOrangesProblem();
            return problem.OrangesRotting(grid);
        }

        public int OrangesRotting(int[][] grid)
        {
            if (grid == null || grid.Length == 0) return 0;
            var rows = grid.Length;
            var cols = grid[0].Length;
            var queue = new Queue<KeyValuePair<int, int>>();

            var freshOrangeCount = 0;
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[0].Length; j++)
                {
                    var current = grid[i][j];
                    switch (current)
                    {
                        case 2:
                            queue.Enqueue(new KeyValuePair<int, int>(i, j));
                            break;
                        case 1:
                            freshOrangeCount++;
                            break;
                    }
                }
            }

            if (freshOrangeCount == 0) return 0;
            var count = 0;
            var dirs = new int[4][];
            dirs[0] = new[] {1, 0};
            dirs[1] = new[] {-1, 0};
            dirs[2] = new[] {0, 1};
            dirs[3] = new[] {0, -1};

            while (queue.Count != 0)
            {
                count++;
                var queueSize = queue.Count;
                for (var i = 0; i < queueSize; i++)
                {
                    var (currentRottenX, currentRottenY) = queue.Dequeue();
                    foreach (var dir in dirs)
                    {
                        var x = currentRottenX + dir[0];
                        var y = currentRottenY + dir[1];
                        if (x < 0 || y < 0 || x >= rows || y >= cols || grid[x][y] == 0 || grid[x][y] == 2) continue;

                        grid[x][y] = 2;

                        queue.Enqueue(new KeyValuePair<int, int>(x, y));
                        freshOrangeCount--;
                    }
                }
            }

            return freshOrangeCount == 0 ? count - 1 : -1;
        }
    }
}