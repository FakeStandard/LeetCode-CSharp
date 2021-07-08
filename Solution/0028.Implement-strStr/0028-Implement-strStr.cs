using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0028.Implement_strStr
{
    public class _0028_Implement_strStr
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
