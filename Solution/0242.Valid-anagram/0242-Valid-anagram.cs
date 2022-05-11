using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0242.Valid_anagram
{
    public class _0242_Valid_anagram
    {
        public bool IsAnagram(string s, string t)
        {
            // Solution 1
            //if (s.Length != t.Length)
            //    return false;

            //char[] ch1 = s.ToCharArray();
            //char[] ch2 = t.ToCharArray();

            //Array.Sort(ch1);
            //Array.Sort(ch2);

            //for (int i = 0; i < ch1.Length; i++)
            //    if (ch1[i] != ch2[i])
            //        return false;

            //return true;

            // Solution 2
            if (s.Length != t.Length) return false;

            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (char c in s)
            {
                if (dic.ContainsKey(c))
                    dic[c] += 1;
                else
                    dic.Add(c, 1);
            }

            foreach (char c in t)
            {
                if (dic.ContainsKey(c))
                {
                    if (dic[c] == 1)
                        dic.Remove(c);
                    else dic[c] -= 1;
                }
                else return false;
            }

            return dic.Count == 0;
        }
    }
}
