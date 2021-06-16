using System;

namespace _0014.Longest_common_prefix
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return null;

            string res = string.Empty;
            string str = strs[0];

            foreach (var s in strs)
            {
                if (s.Length < str.Length)
                    str = s;
            }

            int len = strs.Length;

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    if (str[i] == strs[j][i])
                        continue;
                    else
                        return res;
                }

                res += str[i];
            }

            return res;
        }
    }
}
