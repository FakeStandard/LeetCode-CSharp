using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0791.Custom_sort_string
{
    public class _0791_Custom_sort_string
    {
        public string CustomSortString(string order, string str)
        {
            if (string.IsNullOrEmpty(order) || string.IsNullOrEmpty(str)) return string.Empty;

            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (!dic.ContainsKey(c))
                    dic.Add(c, 0);
                dic[c]++;
            }

            StringBuilder sb = new StringBuilder();

            foreach (char c in order)
            {
                if (dic.ContainsKey(c))
                {
                    while (dic[c] > 0)
                    {
                        sb.Append(c);
                        dic[c]--;
                    }
                }

                dic.Remove(c);
            }

            foreach (char key in dic.Keys)
            {
                int count = dic[key];

                while (count > 0)
                {
                    sb.Append(key);
                    count--;
                }
            }

            return sb.ToString();
        }
    }
}
