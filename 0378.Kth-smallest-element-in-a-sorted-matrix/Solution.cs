using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _0378.Kth_smallest_element_in_a_sorted_matrix
{
    public class Solution
    {
        public int KthSmallest(int[][] matrix, int k)
        {
            if (matrix == null) return 0;

            int row = matrix.Length;
            int col = matrix[0].Length;
            int left = matrix[0][0];
            int right = matrix[row - 1][col - 1];

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                int count = 0;

                for (int i = 0; i < row; i++)
                    for (int j = col - 1; j >= 0; j--)
                        if (matrix[i][j] <= mid)
                            count++;

                if (count < k)
                    left = mid + 1;
                else
                    right = mid;
            }

            return left;

            // Bubble Sort - Time limit exceeded
            //List<int> lists = new List<int>();

            //foreach (var row in matrix)
            //    foreach (var col in row)
            //            lists.Add(col);

            //int temp = 0;

            //for (int i = 0; i < lists.Count; i++)
            //{
            //    for (int j = i + 1; j < lists.Count; j++)
            //    {
            //        if (lists[i] > lists[j])
            //        {
            //            temp = lists[i];
            //            lists[i] = lists[j];
            //            lists[j] = temp;
            //        }
            //    }
            //}

            //return lists[k - 1];
        }
    }
}
