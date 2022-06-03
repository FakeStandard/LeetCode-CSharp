using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0240.Search_a_2D_matrix_II
{
    public class _0240_Search_a_2D_matrix_II
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            // matrix properties.
            // Integers in each row are sorted in ascending from left to right.
            // Integers in each column are sorted in ascending from top to bottom.

            int row = matrix.Length;
            int col = matrix[0].Length;
            int i = row - 1;
            int j = 0;

            while (i >= 0 && j < col)
            {
                if (matrix[i][j] == target)
                    return true;

                if (matrix[i][j] > target)
                    i--;
                else
                    j++;
            }

            return false;

            //暴力破解
            //foreach (int[] arr in matrix)
            //    foreach (int i in arr)
            //        if (i == target) return true;

            //return false;
        }
    }
}
