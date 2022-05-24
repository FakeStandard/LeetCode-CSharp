using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0005.Longest_palindromic_substring
{
    public class _0005_Longest_palindromic_substring
    {
        public string LongestPalindrome(string s)
        {
            if (s.Length <= 1) return s;

            int left = 0, odd, even, curr, max = 0;

            for (int i = 0; i < s.Length; i++)
            {
                // ex: 121
                odd = Palindrome(s, i, i);

                // ex: 1221
                even = Palindrome(s, i, i + 1);

                // compare
                curr = (odd > even ? odd : even);

                if (curr > max)
                {
                    max = curr;
                    left = i - (max - 1) / 2;
                }
            }

            return s.Substring(left, max);
        }

        private int Palindrome(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            return right - left - 1;
        }
    }
}
