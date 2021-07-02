using System;
using System.Collections.Generic;

namespace _0217.Contains_Duplicate
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> hash = new HashSet<int>();

            foreach(var num in nums)
            {
                if (!hash.Add(num))
                    return true;
            }

            return false;

            // Solution 1
             /* Runtime: 2388 ms, faster than 5.19% of C# online submissions for Contains Duplicate.
Memory Usage: 29.5 MB, less than 79.02% of C# online submissions for Contains Duplicate.
             */
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //        if (nums[i] == nums[j])
            //            return true;
            //}

            //return false;
        }
    }
}
