using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0509.Fibonacci_number
{
    public class _0509_Fibonacci_number
    {
        /// <summary>
        /// Iterative solution
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Fib(int n)
        {
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
        }

        /// <summary>
        /// Recursive solution
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        //public int Fib(int n)
        //{
        //    if (n < 2)
        //        return n;

        //    return Fib(n - 1) + Fib(n - 2);
        //}
    }
}
