using System;

namespace _1365.How_many_numbers_are_smaller_than_current_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums;
            int[] result;
            Solution s = new Solution();

            // ex1
            nums = new int[] { 6, 5, 4, 8 };
            foreach (var item in nums)
                Console.Write($"[{item}] ");

            Console.WriteLine();

            result = s.SmallerNumbersThanCurrent(nums);
            foreach (var item in result)
                Console.Write($"[{item}] ");

            Console.WriteLine();

            // ex2
            nums = new int[] { 7, 7, 7, 7 };
            foreach (var item in nums)
                Console.Write($"[{item}] ");

            Console.WriteLine();

            result = s.SmallerNumbersThanCurrent(nums);
            foreach (var item in result)
                Console.Write($"[{item}] ");

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int i, j;
            int count;
            int[] result = new int[nums.Length];

            for (i = 0; i < result.Length; i++)
            {
                count = 0;

                for (j = 0; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i])
                        count++;
                }

                result[i] = count;
            }

            return result;
        }
    }
}
