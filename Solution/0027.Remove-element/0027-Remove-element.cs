using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0027.Remove_element
{
    public class _0027_Remove_element
    {
        public int RemoveElement(int[] nums, int val)
        {
            int res = 0;

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] != val)
                    nums[res++] = nums[i];

            return res;
        }
    }
}
