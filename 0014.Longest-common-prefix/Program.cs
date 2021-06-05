using System;

namespace _0014.Longest_common_prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string[] strs;

            // ex1
            strs = new string[] { "flower", "flow", "flight" };
            // Output: "fl"
            Console.WriteLine(s.LongestCommonPrefix(strs));

            // ex2
            strs = new string[] { "dog", "racecar", "car" };
            // Output: ""
            Console.WriteLine(s.LongestCommonPrefix(strs));

            Console.ReadLine();
        }
    }

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
                for(int j = 0; j < len; j++)
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
