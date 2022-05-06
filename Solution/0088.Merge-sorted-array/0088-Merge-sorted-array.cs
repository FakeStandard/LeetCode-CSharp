using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0088.Merge_sorted_array
{
    public class _0088_Merge_sorted_array
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i, j, tmp, flag;

            for (i = 0; i < n; i++)
                nums1[i + m] = nums2[i];

            //Array.Sort(nums1);

            // bubble sort
            for (i = nums1.Length - 1; i > 0; i--)
            {
                flag = 0;
                for (j = 0; j < i; j++)
                {
                    if (nums1[j] > nums1[j + 1])
                    {
                        // swap
                        tmp = nums1[j];
                        nums1[j] = nums1[j + 1];
                        nums1[j + 1] = tmp;

                        flag++;
                    }
                }

                if (flag == 0) break;
            }
        }
    }
}
