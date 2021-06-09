using System;

namespace _1486.XOR_Operation_in_an_array
{
    public class Solution
    {
        public int XorOperation(int n, int start)
        {
            int res = 0;

            for(int i = 0; i < n; i++)
                res ^= start + 2 * i;

            return res;
        }
    }
}
