using System;

namespace _1688.Count_of_matches_in_tournament
{
    public class Solution
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
