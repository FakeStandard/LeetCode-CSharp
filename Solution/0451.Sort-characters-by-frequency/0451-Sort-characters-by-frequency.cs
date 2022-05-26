using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0451.Sort_characters_by_frequency
{
    public class _0451_Sort_characters_by_frequency
    {
        public string FrequencySort(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (dic.ContainsKey(c))
                    dic[c]++;
                else
                    dic.Add(c, 1);

                //if (!dic.TryAdd(c, 1)) dic[c]++;
            }

            StringBuilder sb = new StringBuilder();
            int max = 0;
            char ch = '0';

            while (dic.Count != 0)
            {
                foreach (KeyValuePair<char, int> pair in dic)
                {
                    if (pair.Value > max)
                    {
                        max = pair.Value;
                        ch = pair.Key;
                    }
                }

                dic.Remove(ch);

                for (int i = 0; i < max; i++)
                    sb.Append(ch);

                max = 0;
            }

            return sb.ToString();
        }
    }
}
