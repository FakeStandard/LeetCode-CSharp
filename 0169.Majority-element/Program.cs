using System;
using System.Collections.Generic;

namespace _0169.Majority_element
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
        public int MajorityElement(int[] nums)
        {
            int num = nums.Length / 2;

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                    dic[nums[i]]++;
                else
                    dic.Add(nums[i], 1);
            }

            foreach(var d in dic)
            {
                if (d.Value > num)
                    return d.Key;
            }

            return 0;
        }
    }
}
