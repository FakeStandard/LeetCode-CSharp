using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0190.Reverse_bits
{
    public class _0190_Reverse_bits
    {
        public uint reverseBits(uint n)
        {
            uint res = 0;
            int bits = 31;

            while (n != 0)
            {
                // 00000010100101000001111010011100
                res += (n & 1) << bits;
                bits--;
                n >>= 1;
            }

            return res;
        }
    }
}
