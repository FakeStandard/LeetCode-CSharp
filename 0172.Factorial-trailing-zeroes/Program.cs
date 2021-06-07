using System;

namespace _0172.Factorial_trailing_zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            s.TrailingZeroes(13);

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int TrailingZeroes(int n)
        {
            // 每 5 就有一個零
            int count = 0;

            while (n > 0)
            {
                count += n / 5;
                n /= 5;
            }

            return count++;
        }
    }
}
