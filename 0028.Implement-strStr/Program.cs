using System;

namespace _0028.Implement_strStr
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrWhiteSpace(haystack) && string.IsNullOrWhiteSpace(needle))
                return 0;

            if (haystack.Contains(needle))
                return haystack.IndexOf(needle);
            else
                return -1;
        }
    }
}
