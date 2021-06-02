using System;
using System.Collections.Generic;
using System.Linq;

namespace _1636.Sort_array_by_increasing_frequency
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
                new int[]{ 1,1,2,2,2,3 },
                new int[]{ 2,3,1,3,2 },
                new int[]{ -1, 1, -6, 4, 5, -6, 1, 4, 1 }
            };

            // ex
            for (int i = 0; i < lists.Count; i++)
            {
                foreach (var item in lists[i])
                    Console.Write($"[{item}] ");

                Console.WriteLine();

                result = s.FrequencySort(lists[i]);

                foreach (var item in result)
                    Console.Write($"[{item}] ");

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int[] FrequencySort(int[] nums)
        {
            return nums
                    .GroupBy(x => x)
                    .OrderBy(x => x.Count())
                    .ThenByDescending(x => x.Key)
                    .SelectMany(x => Enumerable.Repeat(x.Key, x.Count()))
                    .ToArray();
        }
    }
}
