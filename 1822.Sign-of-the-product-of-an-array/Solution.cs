using System;

namespace _1822.Sign_of_the_product_of_an_array
{
    public class Solution
    {
        public int ArraySign(int[] nums)
        {
            int negative = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    return 0;
                else if (nums[i] < 0)
                    negative = -negative;
            }

            return negative;
        }
    }
}
