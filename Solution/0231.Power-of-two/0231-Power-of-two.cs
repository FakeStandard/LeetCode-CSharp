using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0231.Power_of_two
{
    public class _0231_Power_of_two
    {
        public bool IsPowerOfTwo(int n)
        {
            // Shift operators
            return (n > 0) && (n & (n - 1)) == 0;
        }
    }
}
