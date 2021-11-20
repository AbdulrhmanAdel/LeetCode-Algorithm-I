using System;

namespace Algorithm_I.Day7
{
    public class MaxAreaOfIslandProblem
    {
        /*
         * You are given an m x n binary matrix grid.
         * An island is a group of 1's (representing land) connected 4-directionally (horizontal or vertical.)
         * You may assume all four edges of the grid are surrounded by water.
         * The area of an island is the number of cells with a value 1 in the island.
         * Return the maximum area of an island in grid. If there is no island, return 0.
         */


        public static int Run(int[][] grid)
        {
            var problem = new MaxAreaOfIslandProblem();
            return problem.MaxAreaOfIsland(grid);
        }

        
        private int[][] _grid;
        private bool[,] _visited;
        private int _maxArea;
        public int MaxAreaOfIsland(int[][] grid)
        {
            _grid = grid;
            _visited = new bool[grid.Length, grid[0].Length];
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 0) continue;

                    var area = Visit(i, j);
                    _maxArea = Math.Max(area, _maxArea);
                }
            }

            return _maxArea;
        }

        private int Visit(int y, int x)
        {
            if (y < 0 || y >= _grid.Length || x < 0 || x >= _grid[0].Length || _visited[y, x] || _grid[y][x] != 1)
            {
                return 0;
            }

            _visited[y, x] = true;
            return 1 + Visit(y - 1, x) + Visit(y + 1, x) + Visit(y, x + 1) + Visit(y, x - 1);
        }
    }
}