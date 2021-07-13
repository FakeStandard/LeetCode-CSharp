using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1523.Count_odd_numbers_in_an_interval_range
{
    public class _1523_Count_odd_numbers_in_an_interval_range
    {
        public int CountOdds(int low, int high)
        {
            return (high + 1) / 2 - (low / 2);

            #region Time Limit Exceeded
            //int count = 0;

            //while (low <= high)
            //{
            //    if (low % 2 == 1)
            //        count++;
            //    low++;
            //}

            //return count;
            #endregion
        }
    }
}
