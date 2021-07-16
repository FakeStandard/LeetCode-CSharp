using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0018._4Sum
{
    public class _0018_4Sum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            if (nums.Length == 0) return null;

            Array.Sort(nums);

            IList<IList<int>> result = new List<IList<int>>();
            HashSet<(int, int, int, int)> hash = new HashSet<(int, int, int, int)>();
            int left = 0, right = 0, sum = 0;

            for (int i = 0; i < nums.Length - 3; i++)
            {
                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    left = j + 1;
                    right = nums.Length - 1;

                    while (left < right)
                    {
                        sum = nums[i] + nums[j] + nums[left] + nums[right];

                        if (sum == target)
                        {
                            if (!hash.Contains((nums[i], nums[j], nums[left], nums[right])))
                            {
                                result.Add(new List<int>() { nums[i], nums[j], nums[left], nums[right] });
                                hash.Add((nums[i], nums[j], nums[left], nums[right]));
                            }
                            left++;
                            right--;
                        }
                        else if (sum > target)
                            right--;
                        else if (sum < target)
                            left++;
                    }
                }
            }

            return result;
        }
    }
}
