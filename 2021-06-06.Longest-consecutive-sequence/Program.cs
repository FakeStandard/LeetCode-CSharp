using System;

namespace _2021_06_06.Longest_consecutive_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            s.LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2 });
            s.LongestConsecutive(new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 });
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int[] arr = nums;
            QuickSort(ref arr, 0, arr.Length - 1);
            int max = 0;
            int count = 1;
            int point = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                point = arr[i];
                count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    point++;

                    if (point == arr[j])
                    {
                        count++;
                        continue;
                    }
                    else if (point == arr[j] + 1)
                    {
                        point--;
                        continue;
                    }
                    else
                        break;
                }

                if (count > max)
                    max = count;
            }

            return max;
        }

        private void QuickSort(ref int[] arr, int left, int right)
        {
            if (left >= right) return;

            int pivot = arr[left];
            int i = left;
            int j = right;

            int tmp;

            while (i != j)
            {
                while (arr[j] >= pivot && i < j)
                    j--;

                while (arr[i] <= pivot && i < j)
                    i++;

                if (i < j)
                {
                    tmp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = tmp;
                }
            }

            arr[left] = arr[i];
            arr[i] = pivot;

            QuickSort(ref arr, left, i - 1);
            QuickSort(ref arr, i + 1, right);
        }
    }
}
