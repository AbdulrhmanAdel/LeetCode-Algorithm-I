namespace Algorithm_I.Day7
{
    public class FloodFillProblem
    {
        /*
         * An image is represented by an m x n integer grid image where image[i][j] represents the pixel value of the image.
         * You are also given three integers sr, sc, and newColor. You should perform a flood fill on the image starting from the pixel image[sr][sc].
         * To perform a flood fill, consider the starting pixel, plus any pixels connected 4-directionally to the starting pixel of the same color as the starting pixel,
         * plus any pixels connected 4-directionally to those pixels (also with the same color), and so on. Replace the color of all of the aforementioned pixels with newColor.
         * Return the modified image after performing the flood fill.
         */
        
        public static int[][] Run(int[][] image, int sr, int sc, int newColor)
        {
            var problem = new FloodFillProblem();
            return problem.FloodFill(image, sr, sc, newColor);
        }
        
        private  int[][] _image;
        private  bool[,] _visited;
        private  int _oldColor;
        private  int _newColor;
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            _image = image;
            _visited = new bool[image.Length, image[0].Length];
            _oldColor = image[sr][sc];
            _newColor = newColor;
            Visit(sr, sc);
            return image;
        }

        private void Visit(int y, int x)
        {
            if (y < 0 || y >= _image.Length || x < 0 || x >= _image[0].Length || _visited[y, x] || _image[y][x] != _oldColor)
            {
                return;
            }

            _image[y][x] = _newColor;
            _visited[y, x] = true;
            Visit(y + 1, x);
            Visit(y - 1, x);
            Visit(y, x + 1);
            Visit(y, x - 1);
        }
        
    }
}