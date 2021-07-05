using System;

namespace _0136.Single_number
{
    public class Solution
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
