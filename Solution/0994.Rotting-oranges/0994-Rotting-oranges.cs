using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0994.Rotting_oranges
{
    public class _0994_Rotting_oranges
    {
        public int OrangesRotting(int[][] grid)
        {
            if (grid == null || grid.Length == 0) return -1;

            int minute = 0;

            // 2,1,1
            // 0,1,1
            // 1,0,1
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 0) continue;

                    if (grid[i][j] == 2)
                    {
                        minute++;

                        if (i + 1 < grid.Length)
                            if (grid[i + 1][j] == 1)
                                grid[i + 1][j] = 2;

                        if (j + 1 < grid[i].Length)
                            if (grid[i][j + 1] == 1)
                                grid[i][j + 1] = 2;
                    }
                }
            }

            // check the 1
            foreach (int[] arr in grid)
                foreach (int num in arr)
                    if (num == 1) return -1;

            return minute;
        }
    }
}
