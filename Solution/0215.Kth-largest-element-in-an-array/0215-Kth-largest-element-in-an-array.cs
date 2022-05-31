using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0215.Kth_largest_element_in_an_array
{
    public class _0215_Kth_largest_element_in_an_array
    {
        public int FindKthLargest(int[] nums, int k)
        {
            quickSort(nums, 0, nums.Length - 1, nums.Length - k);
            return nums[nums.Length - k];
        }

        private void quickSort(int[] nums, int left, int right, int k)
        {
            int i = left;
            int j = right;
            int pivot = nums[left];
            int temp;

            while (i < j)
            {
                // begin left.
                while (nums[j] >= pivot && i < j)
                    j--;

                // begin right.
                while (nums[i] <= pivot && i < j)
                    i++;

                // swap
                if (i < j)
                {
                    temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }

            // change i & j position.
            nums[left] = nums[j];
            nums[j] = pivot;

            if (j < k)
                quickSort(nums, j + 1, right, k);
            else if (j > k)
                quickSort(nums, left, j - 1, k);
        }
    }
}
