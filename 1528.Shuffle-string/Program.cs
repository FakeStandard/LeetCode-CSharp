using System;
using System.Linq;

namespace _1528.Shuffle_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string str = string.Empty;
            int[] indices;

            str = "codeleet";
            indices = new int[] {4, 5, 6, 7, 0, 2, 1, 3};

            // Output: "leetcode"
            Console.WriteLine(s.RestoreString(str,indices));

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public string RestoreString(string s, int[] indices)
        {
            if (string.IsNullOrWhiteSpace(s)) return null;

            char[] res = new char[s.Length];

            for (int i = 0; i < indices.Length; i++)
                res[indices[i]] = s[i];

            return new string(res);
        }
    }
}
