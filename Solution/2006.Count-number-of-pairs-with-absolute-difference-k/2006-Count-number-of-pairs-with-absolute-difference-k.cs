using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._2006.Count_number_of_pairs_with_absolute_difference_k
{
    public class _2006_Count_number_of_pairs_with_absolute_difference_k
    {
        public int CountKDifference(int[] nums, int k)
        {
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int diff = nums[i] - nums[j];

                    if (i < j && Math.Abs(diff) == k) count++;
                }
            }

            return count;
        }
    }
}
