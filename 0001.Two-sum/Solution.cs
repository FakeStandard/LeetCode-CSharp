using System;

namespace _0001.Two_sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int i, j;

            for (i = 0; i < nums.Length; i++)
                for (j = i + 1; j < nums.Length; j++)
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };

            return null;

            // 透過雙迴圈逐一走訪
            // 因不可與本身計算, 故取 i+1 略過本身, 以及計算過的值
        }
    }
}
