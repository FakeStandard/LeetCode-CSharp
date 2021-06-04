using System;

namespace _1470.Shuffle_the_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            int[] nums;
            int n;
            int[] res;

            // ex1
            nums = new int[] { 2, 5, 1, 3, 4, 7 };
            n = 3;

            // Output:[2,3,5,4,1,7]
            res = s.Shuffle(nums, n);
            foreach (int r in res)
                Console.Write($"{r} ");
            Console.WriteLine();

            // ex2
            nums = new int[] { 1, 2, 3, 4, 4, 3, 2, 1 };
            n = 4;

            // Output:[1,4,2,3,3,2,4,1]
            res = s.Shuffle(nums, n);
            foreach (int r in res)
                Console.Write($"{r} ");
            Console.WriteLine();

            // ex3
            nums = new int[] { 1, 1, 2, 2 };
            n = 2;

            // Output:[1,2,1,2]
            res = s.Shuffle(nums, n);
            foreach (int r in res)
                Console.Write($"{r} ");
            Console.WriteLine();

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int[] Shuffle(int[] nums, int n)
        {
            if (nums.Length == 0) return null;
            if (nums.Length <= n) return nums;

            int[] res = new int[nums.Length];

            for (int i = 0; i < n; i++)
            {
                res[i * 2] = nums[i];
                res[i * 2 + 1] = nums[i + n];
            }

            return res;
        }
    }
}
