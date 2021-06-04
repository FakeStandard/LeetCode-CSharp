using System;

namespace _0069.Sqrt_x
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            int x;

            // ex1
            x = 4;
            Console.WriteLine(s.MySqrt(x));

            // ex2
            x = 8;
            Console.WriteLine(s.MySqrt(x));

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int MySqrt(int x)
        {
            int i = 1;

            while (i < x / i)
                i++;

            if (i > x / i) return i - 1;

            return i;
        }
    }
}
