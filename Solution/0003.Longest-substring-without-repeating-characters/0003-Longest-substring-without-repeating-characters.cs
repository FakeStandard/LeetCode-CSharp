using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0003.Longest_substring_without_repeating_characters
{
    public class _0003_Longest_substring_without_repeating_characters
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0) return 0;

            char[] chars = s.ToCharArray();
            int index = 0, max = 1, res = max;
            HashSet<char> set = new HashSet<char>();
            set.Add(chars[0]);

            for (int i = 1; i < chars.Length; i++)
            {
                if (set.Add(chars[i])) max++;
                else
                {
                    if (max > res) res = max;
                    max = 1;
                    set.Clear();
                    i = ++index;
                    set.Add(chars[i]);
                }
            }

            return max > res ? max : res;
        }
    }
}
