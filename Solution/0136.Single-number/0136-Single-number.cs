using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0136.Single_number
{
    public class _0136_Single_number
    {
        public int SingleNumber(int[] nums)
        {
            int num = nums[0];

            for (int i = 1; i < nums.Length; i++)
                num = num ^ nums[i];

            return num;
        }
    }
}
