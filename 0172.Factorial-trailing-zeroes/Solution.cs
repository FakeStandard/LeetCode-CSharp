using System;

namespace _0172.Factorial_trailing_zeroes
{
    public class Solution
    {
        public int TrailingZeroes(int n)
        {
            int count = 0;

            // there is a zero for every 5 numbers.
            while (n > 0)
            {
                count += n / 5;
                n /= 5;
            }

            return count;
        }
    }
}
