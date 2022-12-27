using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0268.Missing_number
{
    public class _0268_Missing_number
    {
        public int MissingNumber(int[] nums)
        {
            int res = nums.Length;

            for (int i = 0; i < nums.Length; i++)
                res = res ^ i ^ nums[i];

            return res;
        }
    }
}
