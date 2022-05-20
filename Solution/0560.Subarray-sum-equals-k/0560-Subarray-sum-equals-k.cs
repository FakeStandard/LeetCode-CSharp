using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0560.Subarray_sum_equals_k
{
    public class _0560_Subarray_sum_equals_k
    {
        public int SubarraySum(int[] nums, int k)
        {
            // Dictionary
            Dictionary<int, int> dic = new Dictionary<int, int>();
            dic.Add(0, 1);

            int sum = 0;
            int count = 0;

            foreach (int num in nums)
            {
                sum += num;

                if (dic.ContainsKey(sum - k))
                    count += dic[sum - k];

                if (!dic.ContainsKey(sum))
                    dic.Add(sum, 0);

                dic[sum]++;
            }

            return count;

            // Iterative
            //int count = 0;
            //int sum = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    sum = nums[i];

            //    if (sum == k) count++;

            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        sum += nums[j];
            //        if (sum == k) count++;
            //    }

            //}

            //return count;
        }
    }
}
