using System;
using System.Collections.Generic;

namespace _1389.Create_target_array_in_the_given_order
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            List<int> res = new List<int>();

            for(int i = 0; i < nums.Length; i++)
                res.Insert(index[i], nums[i]);

            return res.ToArray();
        }
    }
}
