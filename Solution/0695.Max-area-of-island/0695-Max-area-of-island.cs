using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0695.Max_area_of_island
{
    public class _0695_Max_area_of_island
    {
        private int[][] temp = null;
        private int maxArea = 0;
        private int area = 1;
        private int row;
        private int col;

        public int MaxAreaOfIsland(int[][] grid)
        {
            if (grid == null || grid.Length == 0) return maxArea;

            temp = grid;
            row = grid.Length;
            col = grid[0].Length;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (grid[i][j] == 1)
                        DFS(i, j);

                    // reset a for 1
                    area = 1;
                }
            }

            return maxArea;
        }

        private void DFS(int x, int y)
        {
            maxArea = Math.Max(maxArea, area);

            if (x < 0 || y < 0 || x >= row || y >= col) return;
            temp[x][y] = 0;
            area++;

            // top
            if (x > 0 && temp[x - 1][y] == 1)
                DFS(x - 1, y);

            // bottom
            if (x < row - 1 && temp[x + 1][y] == 1)
                DFS(x + 1, y);

            // left
            if (y > 0 && temp[x][y - 1] == 1)
                DFS(x, y - 1);

            // right
            if (y < col - 1 && temp[x][y + 1] == 1)
                DFS(x, y + 1);
        }
    }
}
