using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0088.Merge_sorted_array
{
    public class _0088_Merge_sorted_array
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            // Solution 1
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

            // Solution 2
            //int i = m - 1, j = n - 1, index = m + n - 1;

            //while (i >= 0 && j >= 0)
            //{
            //    if (nums1[i] > nums2[j])
            //    {
            //        nums1[index] = nums1[i];
            //        i--;
            //    }
            //    else
            //    {
            //        nums1[index] = nums2[j];
            //        j--;
            //    }

            //    index--;
            //}

            //// No need to handle i >= 0 case. If it's the case, the remaining numbers are already in nums1.
            //while (j >= 0)
            //{
            //    nums1[index] = nums2[j];
            //    index--;
            //    j--;
            //}
        }
    }
}
