using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0704.Binary_search
{
    public class _0704_Binary_search
    {
        public int Search(int[] nums, int target)
        {
            // binary search
            int left = 0;
            int right = nums.Length - 1;
            int mid;

            while (left <= right)
            {
                mid = (left + right) / 2;

                if (nums[mid] == target) return mid;
                else if (target > nums[mid]) left = mid + 1;
                else right = mid - 1;
            }

            return -1;
        }
    }
}
