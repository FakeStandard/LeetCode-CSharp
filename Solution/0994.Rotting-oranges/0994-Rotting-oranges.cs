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

            var queue = new Queue<Tuple<int, int, int>>();

            int row = grid.Length;
            int col = grid[0].Length;
            int minute = 0;

            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    if (grid[i][j] == 2)
                        queue.Enqueue(new Tuple<int, int, int>(i, j, minute));

            // BFS
            while (queue.Count > 0)
            {
                var rotten = queue.Dequeue();
                int x = rotten.Item1;
                int y = rotten.Item2;
                int time = rotten.Item3;

                minute = Math.Max(minute, time);

                time++;

                // right
                if (x < row - 1 && grid[x + 1][y] == 1)
                {
                    queue.Enqueue(new Tuple<int, int, int>(x + 1, y, time));
                    grid[x + 1][y] = 2;
                }

                // left
                if (x > 0 && grid[x - 1][y] == 1)
                {
                    queue.Enqueue(new Tuple<int, int, int>(x - 1, y, time));
                    grid[x - 1][y] = 2;
                }

                // top
                if (y > 0 && grid[x][y - 1] == 1)
                {
                    queue.Enqueue(new Tuple<int, int, int>(x, y - 1, time));
                    grid[x][y - 1] = 2;
                }

                // bottom
                if (y < col - 1 && grid[x][y + 1] == 1)
                {
                    queue.Enqueue(new Tuple<int, int, int>(x, y + 1, time));
                    grid[x][y + 1] = 2;
                }
            }

            // Check if all oranges are rotten.
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    if (grid[i][j] == 1)
                        return -1;

            return minute;
        }
    }
}
