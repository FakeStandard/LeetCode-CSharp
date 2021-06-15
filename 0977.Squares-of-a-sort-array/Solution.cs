using System;

namespace _0977.Squares_of_a_sort_array
{
    public class Solution
    {
        public int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
                nums[i] *= nums[i];

            //QuickSort(ref nums, 0, nums.Length - 1);

            // Faster than Quick Sort.
            Array.Sort(nums);

            return nums;
        }

        private void QuickSort(ref int[] data, int left, int right)
        {
            if (left > right)
                return;

            int pivot = data[left];
            int i = left;
            int j = right;
            int temp = 0;

            while (i != j)
            {
                while (data[j] >= pivot && i < j)
                    j--;

                while (data[i] <= pivot && i < j)
                    i++;

                if (i < j)
                {
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                }
            }

            data[left] = data[i];
            data[i] = pivot;

            QuickSort(ref data, left, i - 1);
            QuickSort(ref data, i + 1, right);
        }
    }
}
