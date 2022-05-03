using System;
using System.Collections.Generic;
using System.Text;

namespace _2239.Find_Closest_Number_to_Zero
{
    public class _2239_Find_Closest_Number_to_Zero
    {
        public int FindClosestNumber(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            int res = nums[0];
            int abs = Math.Abs(nums[0]);

            for (int i = 1; i < nums.Length; i++)
            {
                int temp = Math.Abs(nums[i]);
                if (temp < abs)
                {
                    res = nums[i];
                    abs = temp;
                }

                if (temp == abs)
                    if (nums[i] > res)
                        res = nums[i];
            }

            return res;
        }
    }
}
