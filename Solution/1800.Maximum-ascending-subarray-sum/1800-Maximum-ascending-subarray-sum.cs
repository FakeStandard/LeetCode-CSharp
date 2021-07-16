using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1800.Maximum_ascending_subarray_sum
{
    public class _1800_Maximum_ascending_subarray_sum
    {
        public int MaxAscendingSum(int[] nums)
        {
            int max = nums[0];
            int res = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    res += nums[i];
                    if (res > max)
                        max = res;
                }
                else
                    res = nums[i];
            }

            return max;
        }
    }
}
