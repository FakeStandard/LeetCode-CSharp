using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0162.Find_peak_element
{
    public class _0162_Find_peak_element
    {
        public int FindPeakElement(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
                if ((i == 0 || nums[i] > nums[i - 1]) && (i == nums.Length - 1 || nums[i] > nums[i + 1]))
                    return i;

            return 0;
        }
    }
}
