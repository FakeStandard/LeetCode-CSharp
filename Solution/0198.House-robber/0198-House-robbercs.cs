using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0198.House_robber
{
    public class _0198_House_robbercs
    {
        public int Rob(int[] nums)
        {
            int odd = 0, even = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                    odd += nums[i];
                else
                    even += nums[i];
            }
            
            return odd > even ? odd : even;
        }
    }
}
