using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0074.Search_a_2D_Matrix
{
    public class _0074_Search_a_2D_Matrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            // easy solution
            if (matrix.Length == 0) return false;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] > target) return false;
                    if (matrix[i][j] == target) return true;
                }
            }

            return false;

            // binary search
        }
    }
}
