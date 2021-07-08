using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0069.Sqrt_x
{
    public class _0069_Sqrt_x
    {
        public int MySqrt(int x)
        {
            int i = 1;

            while (i < x / i)
                i++;

            if (i > x / i) return --i;
            else return i;
        }
    }
}
