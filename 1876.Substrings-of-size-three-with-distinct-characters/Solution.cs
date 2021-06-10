using System;

namespace _1876.Substrings_of_size_three_with_distinct_characters
{
    public class Solution
    {
        public int CountGoodSubstrings(string s)
        {
            if (s.Length < 3) return 0;
            int count = 0;

            for (int i = 0; i < s.Length - 2; i++)
            {
                if ((s[i] != s[i + 1]) && (s[i + 1] != s[i + 2]) && (s[i + 2] != s[i]))
                    count++;
            }

            return count;
        }
    }
}