using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0290.Word_pattern
{
    public class _0290_Word_pattern
    {
        public bool WordPattern(string pattern, string s)
        {
            string[] str = s.Split(' ');
            if (str.Length != pattern.Length) return false;

            Dictionary<char, string> dic = new Dictionary<char, string>();

            for (int i = 0; i < pattern.Length; i++)
            {
                if (dic.ContainsKey(pattern[i]))
                {
                    if (dic[pattern[i]] != str[i])
                        return false;
                }
                else
                {
                    if (dic.ContainsValue(str[i]))
                        return false;

                    dic.Add(pattern[i], str[i]);
                }
            }

            return true;
        }
    }
}
