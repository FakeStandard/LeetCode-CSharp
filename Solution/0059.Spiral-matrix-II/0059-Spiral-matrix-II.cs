using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0059.Spiral_matrix_II
{
    public class _0059_Spiral_matrix_II
    {
        public int[][] GenerateMatrix(int n)
        {
            int num = 1;
            int top = 0, bottom = n - 1, left = 0, right = n - 1;

            int[][] res = new int[n][];

            for (int i = 0; i < n; i++)
                res[i] = new int[n];

            while (left <= right && top <= bottom)
            {
                // left to right
                for (int i = left; i <= right; i++)
                {
                    res[top][i] = num;
                    num++;
                }

                top++;

                // top to bottom
                for (int j = top; j <= bottom; j++)
                {
                    res[j][right] = num;
                    num++;
                }

                right--;

                // right to left
                for (int i = right; i >= left; i--)
                {
                    res[bottom][i] = num;
                    num++;
                }

                bottom--;

                // bottom to top
                for (int j = bottom; j >= top; j--)
                {
                    res[j][left] = num;
                    num++;
                }

                left++;
            }

            return res;
        }
    }
}
