using System;

namespace _0912.Sort_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums;
            int[] result;
            Solution s = new Solution();

            // ex1
            nums = new int[] { 5, 2, 3, 1 };
            foreach (var item in nums)
                Console.Write($"[{item}] ");

            Console.WriteLine();

            result = s.SortArray(nums);
            foreach (var item in result)
                Console.Write($"[{item}] ");

            Console.WriteLine();

            // ex2
            nums = new int[] { 5, 1, 1, 2, 0, 0 };
            foreach (var item in nums)
                Console.Write($"[{item}] ");

            Console.WriteLine();

            result = s.SortArray(nums);
            foreach (var item in result)
                Console.Write($"[{item}] ");

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int[] SortArray(int[] nums)
        {
            return QuickSort(nums, 0, nums.Length - 1);
        }

        public int[] QuickSort(int[] data, int left, int right)
        {
            if (left >= right)
                return data;

            int pivot = data[left];
            int i = left;
            int j = right;

            int tmp;

            while (i != j)
            {
                while (data[j] >= pivot && i < j)
                    j--;

                while (data[i] <= pivot && i < j)
                    i++;

                if (i < j)
                {
                    tmp = data[j];
                    data[j] = data[i];
                    data[i] = tmp;
                }
            }

            data[left] = data[i];
            data[i] = pivot;

            QuickSort(data, left, i - 1);
            QuickSort(data, i + 1, right);

            return data;
        }
    }
}