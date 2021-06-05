using System;
using System.Collections.Generic;

namespace _0066.Plus_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] digits;
            int[] res;

            digits = new int[] { 9 };
            res = s.PlusOne(digits);
            foreach (var r in res)
                Console.Write($"{r} ");

            Console.WriteLine();
            // ex1
            digits = new int[] { 1, 2, 3 };
            res = s.PlusOne(digits);
            foreach (var r in res)
                Console.Write($"{r} ");
            Console.WriteLine();

            // ex2
            digits = new int[] { 4, 3, 2, 1 };
            res = s.PlusOne(digits);
            foreach (var r in res)
                Console.Write($"{r} ");
            Console.WriteLine();

            // ex3
            digits = new int[] { 0 };
            res = s.PlusOne(digits);
            foreach (var r in res)
                Console.Write($"{r} ");
            Console.WriteLine();

            // test
            digits = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            res = s.PlusOne(digits);
            foreach (var r in res)
                Console.Write($"{r} ");
            Console.WriteLine();

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            if (digits.Length == 0) return null;

            List<int> res = new List<int>();
            bool carry = false;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (i == digits.Length - 1)
                {
                    if (digits[i] + 1 == 10)
                    {
                        res.Add(0);
                        carry = true;
                    }
                    else
                        res.Add(digits[i] + 1);
                }
                else
                {
                    if (carry)
                    {
                        if (digits[i] + 1 == 10)
                        {
                            res.Add(0);
                            carry = true;
                        }
                        else
                        {
                            res.Add(digits[i] + 1);
                            carry = false;
                        }
                    }
                    else
                        res.Add(digits[i]);

                }
            }

            if (carry)
                res.Add(1);

            var r = res.ToArray();

            Array.Reverse(r);

            return r;
        }
    }
}
