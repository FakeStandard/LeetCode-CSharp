using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0326.Power_of_three
{
    public class _0326_Power_of_three
    {
        /// <summary>
        /// Soluton 1
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsPowerOfThree(int n)
        {
            if (n < 1) return false;

            while (n % 3 == 0) n /= 3;

            if (n == 1) return true;
            return false;
        }

        /// <summary>
        /// Solution 2
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        //public bool IsPowerOfThree(int n)
        //{
        //    if (n < 1) return false;

        //    while (n > 1)
        //    {
        //        if (n % 3 != 0)
        //            return false;
        //        n /= 3;
        //    }

        //    return true;
        //}

        /// <summary>
        /// Solution 3
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        //public bool IsPowerOfThree(int n)
        //{
        //    if (n == 1 || n == 3 || n == 9) return true;
        //    if (n < 9) return false;

        //    while ((n > 9) && (n % 9 == 0))
        //        n /= 9;

        //    while ((n > 3) && (n % 3 == 0))
        //        n /= 3;

        //    return n % 3 == 0;
        //}
    }
}
