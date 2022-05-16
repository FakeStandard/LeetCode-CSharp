using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0344.Reverse_string
{
    public class _0344_Reverse_string
    {
        public void ReverseString(char[] s)
        {
            int l = 0, r = s.Length - 1;
            char tmp;

            while (l < r)
            {
                // swap
                tmp = s[l];
                s[l] = s[r];
                s[r] = tmp;

                l++;
                r--;
            }
        }
    }
}
