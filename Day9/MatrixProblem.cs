using System;
using System.Data;
using System.Linq;

namespace Algorithm_I.Day9
{
    public class MatrixProblem
    {
        /*
         * Given an m x n binary matrix mat,
         * return the distance of the nearest 0 for each cell.
         * The distance between two adjacent cells is 1.
         */

        public static int[][] Run(int[][] matrix)
        {
            var problem = new MatrixProblem();
            return problem.UpdateMatrix(matrix);
        }


        public int[][] UpdateMatrix(int[][] mat)
        {
            var rows = mat.Length;
            if (rows == 0) return mat;
            var cols = mat[0].Length;
            var dist = new int[rows][];
            var maxPossibleValue = rows + cols + 1;
            for (var i = 0; i < rows; i++)
            {
                dist[i] = Enumerable.Repeat(maxPossibleValue, cols).ToArray();
            }

            // go from top left ---> bottom right  
            // so every cell is the min of left one in the same row and the above one from the same column plus 1 the same value
            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        dist[i][j] = 0;
                        continue;
                    }
                    if (i > 0)
                    {
                        dist[i][j] = Math.Min(dist[i][j], dist[i - 1][j] + 1);
                    }

                    if (j > 0)
                    {
                        dist[i][j] = Math.Min(dist[i][j], dist[i][j - 1] + 1);
                    }
                }
            }

            // go from bottom right ---> top left 
            // so every cell is the min of right one in the same row and the below one from the same column plus 1 or the same value
            for (var i = rows - 1; i >= 0; i--)
            {
                for (var j = cols - 1; j >= 0; j--)
                {
                    if (i < rows - 1)
                    {
                        dist[i][j] = Math.Min(dist[i][j], dist[i + 1][j] + 1);
                    }

                    if (j < cols - 1)
                    {
                        dist[i][j] = Math.Min(dist[i][j], dist[i][j + 1] + 1);
                    }
                }
            }

            return dist;
        }
    }
}