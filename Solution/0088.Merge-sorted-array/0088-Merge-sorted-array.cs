using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0088.Merge_sorted_array
{
    public class _0088_Merge_sorted_array
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < n; i++)
                nums1[i + m] = nums2[i];

            Array.Sort(nums1);
        }
    }
}
