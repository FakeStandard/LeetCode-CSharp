using System;

namespace _0258.Add_digits
{
    public class Solution
    {
        // Solution 2
        public int AddDigits(int num)
        {
            if (num < 10) return num;
            if (num % 9 == 0) return 9;
            return num % 9;
        }

        // Solution 1
        //public int AddDigits(int num)
        //{
        //    while (num > 9)
        //        num = Add(num);

        //    return num;
        //}

        //private int Add(int num)
        //{
        //    int result = 0;

        //    while (num > 0)
        //    {
        //        result += num % 10;
        //        num /= 10;
        //    }

        //    return result;
        //}
    }
}
