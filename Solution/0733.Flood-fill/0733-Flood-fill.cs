using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0733.Flood_fill
{
    public class _0733_Flood_fill
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            if (image[sr][sc] != newColor)
                DFS(sr, sc, image, image[sr][sc], newColor);

            return image;
        }

        private void DFS(int row, int col, int[][] image, int oldColor, int newColor)
        {
            if (image[row][col] != oldColor) return;

            // change color to new
            image[row][col] = newColor;

            if (row > 0)
                DFS(row - 1, col, image, oldColor, newColor); // top

            if (row < image.Length - 1)
                DFS(row + 1, col, image, oldColor, newColor); // bottom

            if (col > 0)
                DFS(row, col - 1, image, oldColor, newColor); // left

            if (col < image[0].Length - 1)
                DFS(row, col + 1, image, oldColor, newColor); // right
        }
    }
}
