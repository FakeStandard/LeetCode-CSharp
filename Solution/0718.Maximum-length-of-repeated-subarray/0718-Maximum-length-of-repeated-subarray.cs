using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0718.Maximum_length_of_repeated_subarray
{
    public class _0718_Maximum_length_of_repeated_subarray
    {
        public int FindLength(int[] nums1, int[] nums2)
        {
            int max = 0;
            int[,] matrix = new int[nums1.Length + 1, nums2.Length + 1];

            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        matrix[i + 1, j + 1] = matrix[i, j] + 1;

                        if (max < matrix[i + 1, j + 1])
                            max = matrix[i + 1, j + 1];
                    }
                }
            }

            return max;
        }
    }
}
