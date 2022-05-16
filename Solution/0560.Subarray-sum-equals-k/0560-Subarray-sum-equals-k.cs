using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0560.Subarray_sum_equals_k
{
    public class _0560_Subarray_sum_equals_k
    {
        public int SubarraySum(int[] nums, int k)
        {
            int count = 0;
            int sum = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                sum = nums[i];

                if (sum == k) count++;
                else
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        sum += nums[j];
                        if (sum == k) count++;
                    }
                }

                
            }

            //int count = 0;
            //int sum = 0;

            //foreach(int num in nums)
            //{
            //    sum += num;
            //    count++;
            //    if (sum == k) return count; 
            //}


            return count;
        }
    }
}
