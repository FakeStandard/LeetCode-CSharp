using System;

namespace _0771.Jewels_and_stones
{
    public class Solution
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
