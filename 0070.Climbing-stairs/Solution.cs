using System;

namespace _0070.Climbing_stairs
{
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
