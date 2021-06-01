using System;
using System.Collections.Generic;

namespace _1480.Running_sum_of_1d_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums;
            int[] result;
            Solution s = new Solution();

            List<int[]> lists = new List<int[]>()
            {
                new int[]{ 1, 2, 3, 4 },
                new int[]{ 1, 1, 1, 1, 1 },
                new int[]{ 3, 1, 2, 10, 1 }
            };

            // ex
            for (int i = 0; i < lists.Count; i++)
            {
                foreach (var item in lists[i])
                    Console.Write($"[{item}] ");

                Console.WriteLine();

                result = s.RunningSum(lists[i]);

                foreach (var item in result)
                    Console.Write($"[{item}] ");

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int[] RunningSum(int[] nums)
        {
            //int i, j, tmp;
            //int[] result = new int[nums.Length];

            //for (i = 0; i < nums.Length; i++)
            //{
            //    tmp = 0;

            //    for (j = 0; j <= i; j++)
            //        tmp = tmp + nums[j];

            //    result[i] = tmp;
            //}

            //return result;

            for (int i = 1; i < nums.Length; i++)
                nums[i] = nums[i] + nums[i - 1];

            return nums;
        }
    }
}
