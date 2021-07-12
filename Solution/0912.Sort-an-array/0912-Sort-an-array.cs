using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0912.Sort_an_array
{
    public class _0912_Sort_an_array
    {
        public int[] SortArray(int[] nums)
        {
            //Array.Sort(nums);
            //return nums;

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

        //public int[] QuickSort(int[] data, int left, int right)
        //{
        //    if (left >= right)
        //        return data;

        //    int pivot = data[left];
        //    int i = left;
        //    int j = right;

        //    int tmp;

        //    while (i != j)
        //    {
        //        while (data[j] >= pivot && i < j)
        //            j--;

        //        while (data[i] <= pivot && i < j)
        //            i++;

        //        if (i < j)
        //        {
        //            tmp = data[j];
        //            data[j] = data[i];
        //            data[i] = tmp;
        //        }
        //    }

        //    data[left] = data[i];
        //    data[i] = pivot;

        //    QuickSort(data, left, i - 1);
        //    QuickSort(data, i + 1, right);

        //    return data;
        //}
    }
}
