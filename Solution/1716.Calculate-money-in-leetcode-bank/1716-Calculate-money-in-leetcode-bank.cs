using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1716.Calculate_money_in_leetcode_bank
{
    public class _1716_Calculate_money_in_leetcode_bank
    {
        /// <summary>
        /// Trapezoid formula
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int TotalMoney(int n)
        {
            int week = n / 7;
            int day = n % 7;
            int sum = 0;

            if (week > 0)
                sum += ((1 + 7) * 7 / 2 * week) + ((week) * (week - 1) / 2) * 7 + ((1 + week + day + week) * day / 2);
            else
                sum += (1 + day) * day / 2;

            return sum;
        }

        /// <summary>
        /// Iteration
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        //public int TotalMoney(int n)
        //{
        //    int week = n / 7;
        //    int day = n % 7;

        //    int sum = 0;
        //    int point = 1;

        //    for (int i = 0; i < week; i++)
        //    {
        //        for (int j = 0 + point; j < 7 + point; j++)
        //            sum += j;
        //        point++;
        //    }

        //    for (int k = 0; k < day; k++)
        //        sum += k + point;

        //    return sum;
        //}
    }
}
