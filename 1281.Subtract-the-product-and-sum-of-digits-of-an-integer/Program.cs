﻿using System;
using System.Collections.Generic;

namespace _1281.Subtract_the_product_and_sum_of_digits_of_an_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int n;
            n = 234;
            // Output: 15
            Console.WriteLine(s.SubtractProductAndSum(n));

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int SubtractProductAndSum(int n)
        {
            if (n == 0) return 0;

            int p = 1;
            int s = 0;
            int num = 0;

            while (n > 0)
            {
                num = n % 10;
                p *= num;
                s += num;
                n /= 10;
            }

            return p - s;
        }
    }
}
