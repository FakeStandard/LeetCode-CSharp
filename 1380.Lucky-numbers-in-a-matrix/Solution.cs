using System;
using System.Collections.Generic;
using System.Linq;

namespace _1380.Lucky_numbers_in_a_matrix
{
    public class Solution
    {
        public IList<int> LuckyNumbers(int[][] matrix)
        {
            IList<int> res = new List<int>();
            int min = int.MaxValue;
            int i, j, k, column = 0;
            bool flag = true;

            for (i = 0; i < matrix.Length; i++)
            {
                flag = true;
                min = int.MaxValue;

                // Find the smallest value.
                for (j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] < min)
                    {
                        min = matrix[i][j];
                        column = j;
                    }
                }

                // Judge the maximum value.
                for (k = 0; k < matrix.Length; k++)
                {
                    if (matrix[k][column] > min)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                    res.Add(min);
            }

            return res;
        }
    }
}
