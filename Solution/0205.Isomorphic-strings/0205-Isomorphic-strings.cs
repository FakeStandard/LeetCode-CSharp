using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0205.Isomorphic_strings
{
    public class _0205_Isomorphic_strings
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;

            Dictionary<char, char> dic = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    if (dic[s[i]] != t[i])
                        return false;
                }
                else
                {
                    if (dic.ContainsValue(t[i]))
                        return false;
                    else
                        dic.Add(s[i], t[i]);
                }
            }

            return true;
        }
    }
}
