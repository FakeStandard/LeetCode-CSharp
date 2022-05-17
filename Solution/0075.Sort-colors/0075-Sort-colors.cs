using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0075.Sort_colors
{
    public class _0075_Sort_colors
    {
        public void SortColors(int[] nums)
        {
            //BubbleSort(nums);
            //QuickSort(nums, 0, nums.Length - 1);
            SelectionSort(nums);
        }

        // Similar to bubble sort
        private void SelectionSort(int[] nums)
        {
            int minIndex = 0, tmp = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                minIndex = i;

                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[j] < nums[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // 將最小值與開頭第一個元素對調
                tmp = nums[i];
                nums[i] = nums[minIndex];
                nums[minIndex] = tmp;
            }
        }

        private void QuickSort(int[] data, int left, int right)
        {
            // 如果左邊大於或等於右邊則離開
            if (left >= right) return;

            // 基準數取第一個資料
            int pivot = data[left];

            // 左右代理人
            int i = left, j = right;
            int tmp;

            while (i != j)
            {
                // 從右邊開始找
                while (data[j] >= pivot && i < j) j--;

                // 再從左邊開始找
                while (data[i] <= pivot && i < j) i++;

                // 交換
                if (i < j)
                {
                    tmp = data[i];
                    data[i] = data[j];
                    data[j] = tmp;
                }
            }

            // 基準數與 J 代理交換位置
            data[left] = data[i];
            data[i] = pivot;

            // 遞歸處理左半邊
            QuickSort(data, left, i - 1);

            // 遞歸處理右半邊
            QuickSort(data, i + 1, right);
        }

        private void BubbleSort(int[] nums)
        {
            int flag = 0, tmp = 0;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                flag = 0;

                for (int j = 0; j < i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        // swap
                        tmp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = tmp;

                        flag++;
                    }
                }

                if (flag == 0) break;
            }
        }
    }
}
