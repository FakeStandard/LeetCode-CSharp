using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0709.To_lower_case
{
    public class _0709_To_lower_case
    {
        public string ToLowerCase(string s)
        {
            // Solution 1
            //return s.ToLower();

            // Solution 2
            char[] ch = s.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
                if (ch[i] >= 'A' && ch[i] <= 'Z')
                    ch[i] = (char)(ch[i] + 32);

            return new string(ch);
        }
    }
}
