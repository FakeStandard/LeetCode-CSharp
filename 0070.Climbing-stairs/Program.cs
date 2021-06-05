using System;

namespace _0070.Climbing_stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int n;

            // ex1
            n = 2;
            // Output: 2
            Console.WriteLine(s.ClimbStairs(n));

            // ex2
            n = 3;
            // Output: 3
            Console.WriteLine(s.ClimbStairs(n));

            // test
            n = 10;
            // Output: 
            Console.WriteLine(s.ClimbStairs(n));

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int ClimbStairs(int n)
        {
            // Fibonacci
            // Use Dynamic Programming Algorithm.
            if (n < 0) return 0;
            if (n <= 2) return n;

            int f1 = 1;
            int f2 = 2;
            int result = 0;

            for (int i = 2; i < n; i++)
            {
                result = f1 + f2;
                f1 = f2;
                f2 = result;
            }

            return f2;
        }
    }
}
