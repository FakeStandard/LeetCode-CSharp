using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1486.XOR_Operation_in_an_array
{
    public class _1486_XOR_Operation_in_an_array
    {
        public int XorOperation(int n, int start)
        {
            int res = 0;

            for (int i = 0; i < n; i++)
                res ^= start + 2 * i;

            return res;
        }
    }
}
