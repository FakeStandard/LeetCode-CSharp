using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0053.Maximum_subarray
{
    public class _0053_Maximum_subarray
    {
        public int MaxSubArray(int[] nums)
        {
            int max = nums[0];
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (nums[i] > sum)
                    sum = nums[i];
                if (sum > max)
                    max = sum;
            }

            return max;
        }
    }
}
