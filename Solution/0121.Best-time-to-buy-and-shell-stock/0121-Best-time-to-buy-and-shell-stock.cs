using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0121.Best_time_to_buy_and_shell_stock
{
    public class _0121_Best_time_to_buy_and_shell_stock
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0) return 0;

            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < prices.Length; i++)
            {
                // it's faster than using Math method
                if (prices[i] < min) min = prices[i];
                if (prices[i] - min > max) max = prices[i] - min;

                //min = Math.Min(min, prices[i]);
                //max = Math.Max(max, prices[i] - min);
            }

            return max;
        }
    }
}
