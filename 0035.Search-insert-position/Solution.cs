using System;

namespace _0035.Search_insert_position
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int l = 0, p = 0, r = nums.Length - 1;

            while (l <= r)
            {
                p = (l + r) / 2;

                if (nums[p] == target)
                    return p;

                if (nums[p] > target)
                    r = p - 1;
                else
                    l = p + 1;
            }

            return l;

            //for(int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] == target)
            //        return i;
            //    else if (nums[i] > target)
            //        return i--;
            //}

            //return nums.Length;
        }
    }
}
