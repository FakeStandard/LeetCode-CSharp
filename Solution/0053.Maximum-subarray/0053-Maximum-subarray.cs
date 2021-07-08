using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0053.Maximum_subarray
{
    public class _0053_Maximum_subarray
    {
        public int MaxSubArray(int[] nums)
        {
            int max = int.MinValue;
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum > max)
                        max = sum;
                }
            }

            return max;
        }
    }
}
