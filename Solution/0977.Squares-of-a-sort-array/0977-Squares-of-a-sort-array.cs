using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0977.Squares_of_a_sort_array
{
    public class _0977_Squares_of_a_sort_array
    {
        public int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
                nums[i] *= nums[i];

            //QuickSort(ref nums, 0, nums.Length - 1);

            // Faster than Quick Sort.
            //Array.Sort(nums);

            QuickSort(ref nums, 0, nums.Length - 1);

            return nums;
        }

        private void QuickSort(ref int[] data, int left, int right)
        {
            if (left >= right)
                return;

            int i = Partition(data, left, right);
            QuickSort(ref data, left, i - 1);
            QuickSort(ref data, i + 1, right);
        }

        private int Partition(int[] data, int left, int right)
        {
            int i = left;
            int pivot = data[right];

            for (int j = left; j < right; j++)
            {
                if (data[j] < pivot)
                {
                    Swap(ref data, i, j);
                    i++;
                }
            }

            Swap(ref data, i, right);

            return i;
        }

        private void Swap(ref int[] nums, int i, int j)
        {
            int tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
        }

        //private void QuickSort(ref int[] data, int left, int right)
        //{
        //    if (left > right)
        //        return;

        //    int pivot = data[left];
        //    int i = left;
        //    int j = right;
        //    int temp = 0;

        //    while (i != j)
        //    {
        //        while (data[j] >= pivot && i < j)
        //            j--;

        //        while (data[i] <= pivot && i < j)
        //            i++;

        //        if (i < j)
        //        {
        //            temp = data[i];
        //            data[i] = data[j];
        //            data[j] = temp;
        //        }
        //    }

        //    data[left] = data[i];
        //    data[i] = pivot;

        //    QuickSort(ref data, left, i - 1);
        //    QuickSort(ref data, i + 1, right);
        //}
    }
}
