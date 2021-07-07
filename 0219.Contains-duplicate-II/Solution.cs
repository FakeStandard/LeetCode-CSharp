using System;
using System.Collections.Generic;

namespace _0219.Contains_duplicate_II
{
    public class Solution
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]) && i - dic[nums[i]] <= k)
                    return true;
                dic[nums[i]] = i;
            }

            return false;
        }
    }
}
