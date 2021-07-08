using System;

namespace _0392.Is_subsequence
{
    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0) return true;

            int i=0, j=0;

            while (i < s.Length && j < t.Length)
            {
                if (s[i] == t[j])
                    i++;
                j++;
            }

            return i == s.Length;
        }
    }
}
