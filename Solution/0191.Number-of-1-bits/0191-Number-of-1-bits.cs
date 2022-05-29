using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0191.Number_of_1_bits
{
    public class _0191_Number_of_1_bits
    {
        public int HammingWeight(uint n)
        {
            int count = 0;

            while (n != 0)
            {
                uint curr = n;

                // 1&1 = 1
                if ((curr & 1) == 1)
                    count++;

                n >>= 1;
            }

            return count;
        }
    }
}
