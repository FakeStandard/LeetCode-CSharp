using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0035.Search_insert_position
{
    public class _0035_Search_insert_position
    {
        public int SearchInsert(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1, mid;

            while (left <= right)
            {
                mid = (left + right) / 2;

                if (nums[mid] == target) return mid;
                else if (target > nums[mid]) left = mid + 1;
                else right = mid - 1;
            }

            return left;
        }
    }
}
