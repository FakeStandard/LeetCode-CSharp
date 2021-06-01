using System;

namespace _0977.Squares_of_a_sort_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, -1, 0, 3, 10 };

            Solution s = new Solution();

            int[] result = s.SortedSquares(arr);

            foreach (var item in result)
                Console.Write($"[{item}] ");

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
                nums[i] = nums[i] * nums[i];

            Array.Sort(nums);

            return nums;
        }
    }
}
