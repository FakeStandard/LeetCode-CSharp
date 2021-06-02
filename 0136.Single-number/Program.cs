using System;
using System.Collections.Generic;

namespace _0136.Single_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums;
            int result;
            Solution s = new Solution();

            List<int[]> lists = new List<int[]>()
            {
                new int[]{ 2,2,1 },
                new int[]{ 4,1,2,1,2 },
                new int[]{ 1 },
                new int[]{ 1,8,9,4,3,8,1,4,3}
            };

            // ex
            for (int i = 0; i < lists.Count; i++)
            {
                foreach (var item in lists[i])
                    Console.Write($"[{item}] ");

                Console.WriteLine();

                result = s.SingleNumber(lists[i]);

                Console.Write($"[{result}] ");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            // 使用 XOR 邏輯互斥
            int num = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                num = num ^ nums[i];
            }

            return num;

            //Dictionary<int, bool> dic = new Dictionary<int, bool>();

            //foreach(int num in nums)
            //{
            //    if (dic.ContainsKey(num))
            //        dic[num] = false;
            //    else
            //        dic.Add(num, true);
            //}

            //foreach(var k in dic)
            //{
            //    if (k.Value)
            //        return k.Key;
            //}

            //return 0;
        }
    }
}
