using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1672.Richest_customer_wealth
{
    public class _1672_Richest_customer_wealth
    {
        public int MaximumWealth(int[][] accounts)
        {
            int i, j, sum;
            int max = 0;

            for (i = 0; i < accounts.GetLength(0); i++)
            {
                sum = 0;

                for (j = 0; j < accounts[i].Length; j++)
                    sum += accounts[i][j];

                if (sum >= max)
                    max = sum;
            }

            return max;

            //if (accounts.Length == 0) return 0;

            //int max = 0;

            //for(int i = 0; i < accounts.Length; i++)
            //{
            //    int sum = accounts[i].Sum();
            //    max = Math.Max(max, sum);
            //}

            //return max;
        }
    }
}
