using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0258.Add_digits
{
    public class _0258_Add_digits
    {
        /// <summary>
        /// Solution 2
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int AddDigits(int num)
        {
            if (num < 10) return num;
            if (num % 9 == 0) return 9;
            return num % 9;
        }

        /// <summary>
        /// Solution 1
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
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
