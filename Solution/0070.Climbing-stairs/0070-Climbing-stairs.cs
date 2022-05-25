using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0070.Climbing_stairs
{
    public class _0070_Climbing_stairs
    {
        public int ClimbStairs(int n)
        {
            // Use Dynamic Programming Algorithm.
            if (n < 0) return 0;
            if (n <= 2) return n;

            int f1 = 1;
            int f2 = 2;
            int result = 0;

            for (int i = 2; i < n; i++)
            {
                result = f1 + f2;
                f1 = f2;
                f2 = result;
            }

            return f2;
        }
    }
}
