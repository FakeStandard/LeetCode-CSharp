using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0566.Reshape_the_matrix
{
    public class _0566_Reshape_the_matrix
    {
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            int m = mat.Length;
            int n = mat[0].Length;

            if (mat == null || r * c != m * n) return mat;

            int[][] res = new int[r][];

            for (int i = 0; i < res.Length; i++)
            {
                res[i] = new int[c];

                for (int j = 0; j < c; j++)
                    res[i][j] = mat[(i * c + j) / n][(i * c + j) % n];
            }

            return res;
        }
    }
}
