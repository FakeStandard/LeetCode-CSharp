using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0476.Number_complement
{
    public class _0476_Number_complement
    {
        public int FindComplement(int num)
        {
            for (int i = 0; (1 << i) <= num && i < 31; i++)
                num = num ^ (1 << i);

            return num;
        }
    }
}