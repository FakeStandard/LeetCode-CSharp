using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0048.Rotate_image
{
    public class _0048_Rotate_image
    {
        public void Rotate(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0) return;

            // rotate the matrix by 90 degrees(clockwise).

            // copy
            var temp = new int[matrix.Length][];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = new int[matrix[i].Length];

                for (int j = 0; j < matrix[i].Length; j++)
                    temp[i][j] = matrix[i][j];
            }

            int m = 0;
            int n = temp.Length - 1;

            for (int i = 0; i < temp.Length; i++)
            {
                m = 0;
                for (int j = 0; j < temp[i].Length; j++)
                {
                    matrix[m][n] = temp[i][j];
                    m++;
                }

                n--;
            }
        }
    }
}
