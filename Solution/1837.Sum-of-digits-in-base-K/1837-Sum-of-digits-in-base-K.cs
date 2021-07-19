using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1837.Sum_of_digits_in_base_K
{
    public class _1837_Sum_of_digits_in_base_K
    {
        public int SumBase(int n, int k)
        {
            int res = 0;

            while (n > 0)
            {
                res += n % k;
                n /= k;
            }

            return res;
        }
    }
}
