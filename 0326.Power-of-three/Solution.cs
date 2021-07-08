using System;

namespace _0326.Power_of_three
{
    public class Solution
    {
        public bool IsPowerOfThree(int n)
        {
            // Soluton 1
            if (n < 1) return false;

            while (n % 3 == 0) n /= 3;

            if (n == 1) return true;
            return false;

            // Solution 2
            //if (n < 1) return false;

            //while (n > 1)
            //{
            //    if (n % 3 != 0)
            //        return false;
            //    n /= 3;
            //}

            //return true;

            // Solution 3
            //if (n == 1 || n == 3 || n == 9) return true;
            //if (n < 9) return false;

            //while ((n > 9) && (n % 9 == 0))
            //    n /= 9;

            //while ((n > 3) && (n % 3 == 0))
            //    n /= 3;

            //return n % 3 == 0;
        }
    }
}
