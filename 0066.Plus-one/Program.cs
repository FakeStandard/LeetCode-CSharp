using System;
using System.Collections.Generic;

namespace _0066.Plus_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            int[] digits = { 9,8,7,6,5,4,3,2,1,0 };

            s.PlusOne(digits);

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            if (digits.Length == 0) return null;

            int i;
            double nums = 0;

            for (i = 1; i <= digits.Length; i++)
                nums += digits[i - 1] * Math.Pow(10, digits.Length - i);

            nums++;

            List<int> arr = new List<int>();

            while (nums > 0)
            {
                arr.Add(int.Parse(nums % (10,0)));
                nums /= 10;
            }

            List<int> res = new List<int>();

            for (i = arr.Count - 1; i >= 0; i--)
            {
                res.Add(arr[i]);
            }

            return res.ToArray();
        }
    }
}
