using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1688.Count_of_matches_in_tournament
{
    public class _1688_Count_of_matches_in_tournament
    {
        public int NumberOfMatches(int n)
        {
            int count = 0;

            while (n > 1)
            {
                count += n / 2;
                n = n / 2 + n % 2;
            }

            return count;
        }
    }
}
