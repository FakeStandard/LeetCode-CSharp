using System;

namespace _1512.Number_of_good_pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            int[] nums;

            // ex1
            nums = new int[] { 1, 2, 3, 1, 1, 3 };

            // Output: 4
            Console.WriteLine(s.NumIdenticalPairs(nums));

            // ex2
            nums = new int[] { 1, 1, 1, 1 };

            // Output: 6
            Console.WriteLine(s.NumIdenticalPairs(nums));

            // ex3
            nums = new int[] { 1, 2, 3, };

            // Output: 0
            Console.WriteLine(s.NumIdenticalPairs(nums));

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int NumIdenticalPairs(int[] nums)
        {
            int i, j, count = 0;

            for (i = 0; i < nums.Length; i++)
                for (j = i + 1; j < nums.Length; j++)
                    if (nums[i] == nums[j])
                        count++;

            return count;
        }
    }
}
