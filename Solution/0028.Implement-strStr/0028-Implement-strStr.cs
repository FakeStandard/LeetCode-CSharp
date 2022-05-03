using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0028.Implement_strStr
{
    public class _0028_Implement_strStr
    {
        public int StrStr(string haystack, string needle)
        {
            // 直接使用 IndexOf 方法回傳結果
            // By default, it return -1 if nothing is found.
            return haystack.IndexOf(needle);

            //if (string.IsNullOrWhiteSpace(haystack) && string.IsNullOrWhiteSpace(needle))
            //    return 0;

            //if (haystack.Contains(needle))
            //    return haystack.IndexOf(needle);
            //else
            //    return -1;
        }
    }
}
