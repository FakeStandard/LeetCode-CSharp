using System;

namespace _1844.Replace_all_digits_with_characters
{
    public class Solution
    {
        public string ReplaceDigits(string s)
        {
            char[] res = new char[s.Length];

            res[0] = s[0];
            res[s.Length - 1] = s[s.Length - 1];

            for(int i = 1; i < s.Length; i+=2)
            {
                res[i-1] = s[i-1];
                res[i] = (char)(s[i - 1] + s[i] - '0');
            }

            return new string(res);
        }
    }
}
