using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0542._01_Matrix
{
    public class _0542_01_Matrix
    {
        private int[][] res = null;
        private int row;
        private int col;

        public int[][] UpdateMatrix(int[][] mat)
        {
            if (mat.Length == 0) return mat;

            res = mat;
            row = mat.Length;
            col = mat[0].Length;

            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    if (res[i][j] == 1 && !hasNeighborZero(i, j))
                        res[i][j] = int.MaxValue;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (res[i][j] != 1) continue;

                    DFS(i, j, 1);
                }
            }

            return res;

        }

        private void DFS(int x, int y, int val)
        {
            if (x < 0 || x >= row || y < 0 || y >= col || res[x][y] < val) return;

            res[x][y] = val;

            val++;
            DFS(x - 1, y, val); // top
            DFS(x + 1, y, val); // bottom
            DFS(x, y - 1, val); // left
            DFS(x, y + 1, val); // right
        }

        private bool hasNeighborZero(int x, int y)
        {
            // top
            if (x > 0 && res[x - 1][y] == 0) return true;

            // bottom
            if (x < row - 1 && res[x + 1][y] == 0) return true;

            // left
            if (y > 0 && res[x][y - 1] == 0) return true;

            // right
            if (y < col - 1 && res[x][y + 1] == 0) return true;

            return false;
        }
    }
}
