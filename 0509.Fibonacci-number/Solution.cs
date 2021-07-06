using System;

namespace _0509.Fibonacci_number
{
    public class Solution
    {
        public int Fib(int n)
        {
            // Iterative solution
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            int fib0 = 0;
            int fib1 = 1;

            for (int i = 2; i <= n; i++)
            {
                int tmp = fib0;
                fib0 = fib1;
                fib1 = fib0 + tmp;
            }

            return fib1;

            // Recursive solution
            //if (n < 2)
            //    return n;

            //return Fib(n - 1) + Fib(n - 2);
        }
    }
}
