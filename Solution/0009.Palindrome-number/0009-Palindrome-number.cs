using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0009.Palindrome_number
{
    public class _0009_Palindrome_number
    {
        public bool IsPalindrome(int x)
        {
            if (x == 0)
                return true;

            if (x < 0 || x % 10 == 0)
                return false;

            int reverseNum = 0;

            while (x > reverseNum)
            {
                reverseNum = reverseNum * 10 + x % 10;
                x /= 10;
            }

            return x == reverseNum || x == reverseNum / 10;
        }
    }
}
