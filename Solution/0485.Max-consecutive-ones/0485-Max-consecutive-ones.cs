using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0485.Max_consecutive_ones
{
    public class _0485_Max_consecutive_ones
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            // to be Optimized
            int max = 0;
            int temp = 0;

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] == 1) temp++;
                else
                {
                    max = max > temp ? max : temp;
                    temp = 0;
                }

            return max > temp ? max : temp;
        }

        private int GetMax(int num1, int num2) => num1 > num2 ? num1 : num2;
    }
}
