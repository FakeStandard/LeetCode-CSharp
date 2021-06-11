using System;

namespace _1784.Check_if_binary_string_has_at_most_one_segment_of_ones
{
    public class Solution
    {
        public bool CheckOnesSegment(string s)
        {
            if (s == string.Empty || s == null) return false;

            return s.IndexOf("01") == -1;
        }
    }
}