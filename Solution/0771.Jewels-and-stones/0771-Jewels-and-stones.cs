using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0771.Jewels_and_stones
{
    public class _0771_Jewels_and_stones
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            int count = 0;

            foreach (var s in stones)
                if (jewels.Contains(s))
                    count++;

            return count;
        }
    }
}
