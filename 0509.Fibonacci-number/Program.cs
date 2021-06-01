using System;

namespace _0509.Fibonacci_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int result;

            // ex1
            n = 2;
            result = Fib(n);
            Console.WriteLine(result);

            // ex2
            n = 3;
            result = Fib(n);
            Console.WriteLine(result);

            // ex3
            n = 4;
            result = Fib(n);
            Console.WriteLine(result);

            Console.ReadLine();
        }

        public static int Fib(int n)
        {
            //if (n < 2)
            //    return n;

            //return Fib(n - 1) + Fib(n - 2);

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
    }
}
