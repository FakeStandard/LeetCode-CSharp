using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0198.House_robber
{
    public class _0198_House_robbercs
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];

            int prev = nums[0];
            int max = Math.Max(prev, nums[1]);

            if (nums.Length == 2) return max;

            int curr = 0;

            for (int i = 2; i < nums.Length; i++)
            {
                curr = Math.Max(prev + nums[i], max);
                prev = max;
                max = curr;
            }

            return max;
        }
    }
}
