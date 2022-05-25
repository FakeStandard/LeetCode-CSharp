using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0238.Product_of_array_except_self
{
    public class _0238_Product_of_array_except_self
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] res = new int[nums.Length];
            int temp = 1;

            // product from left to right
            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = temp;
                temp *= nums[i];
            }

            temp = 1;

            // product from right to left
            for (int j = res.Length - 1; j >= 0; j--)
            {
                res[j] *= temp;
                temp *= nums[j];
            }

            return res;
        }
    }
}
