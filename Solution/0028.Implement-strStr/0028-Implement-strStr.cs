using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0028.Implement_strStr
{
    public class _0028_Implement_strStr
    {
        public int StrStr(string haystack, string needle)
        {
            // Solution 3
            // Implement the StrStr method without using the implemented method.
            if (needle.Length == 0) return 0;
            if (needle.Length > haystack.Length) return -1;

            int i = 0, j = 0, index = 0;
            while (i < haystack.Length)
            {
                if (haystack[i] == needle[j])
                {
                    // accumulate
                    i++;
                    j++;

                    if (j == needle.Length) return index;
                }
                else
                {
                    // recalculate
                    index++;
                    i = index;
                    j = 0;
                }
            }

            return -1;

            // Solution 2
            // 直接使用 IndexOf 方法回傳結果
            // By default, it return -1 if nothing is found.
            //return haystack.IndexOf(needle);

            // Solution 1
            //if (string.IsNullOrWhiteSpace(haystack) && string.IsNullOrWhiteSpace(needle))
            //    return 0;

            //if (haystack.Contains(needle))
            //    return haystack.IndexOf(needle);
            //else
            //    return -1;
        }
    }
}
