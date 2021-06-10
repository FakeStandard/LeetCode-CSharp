using System;

namespace _1848.Minimum_distance_to_the_target_element
{
    public class Solution
    {
        public int GetMinDistance(int[] nums, int target, int start)
        {
            int min = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    min = Math.Min(min, Math.Abs(i - start));
            }

            return min;
        }
    }
}
