using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0387.First_unique_character_in_a_string
{
    public class _0387_First_unique_character_in_a_string
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (dic.ContainsKey(c))
                    dic[c] += 1;
                else
                    dic.Add(c, 1);
            }

            for (int i = 0; i < s.Length; i++)
                if (dic[s[i]] == 1)
                    return i;

            return -1;

            //int res = s.IndexOf(dic.FirstOrDefault(x => x.Value == 1).Key);

            //return res;
        }
    }
}
