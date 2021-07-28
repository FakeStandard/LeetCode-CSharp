using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0016._3Sum_closest
{
    public class _0016_3Sum_closest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);

            int left = 0;
            int right = 0;
            int sum = 0;
            int diff = 0;
            int closer = int.MaxValue;
            int res = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                left = i + 1;
                right = nums.Length - 1;

                while (left < right)
                {
                    sum = nums[i] + nums[left] + nums[right];

                    if (sum == target)
                        return sum;
                    if (sum < target)
                        left++;
                    if (sum > target)
                        right--;

                    diff = Math.Abs(target - sum);

                    if (closer > diff)
                    {
                        closer = diff;
                        res = sum;
                    }
                }
            }

            return res;
        }
    }
}
