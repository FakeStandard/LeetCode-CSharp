using System;

namespace _0028.Implement_strStr
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrWhiteSpace(haystack) && string.IsNullOrWhiteSpace(needle))
                return 0;

            if (haystack.Contains(needle))
                return haystack.IndexOf(needle);
            else
                return -1;
        }
    }
}
