using System;

namespace _0125.Valid_palindrome
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;

            int left = 0;
            int right = s.Length - 1;

            s = s.ToLower();

            while (left < right)
            {
                while ((left < right) && (s[left] < 'a' || s[left] > 'z') && (s[left] < '0' || s[left] > '9'))
                    left++;
                while ((left < right) && (s[right] < 'a' || s[right] > 'z') && (s[right] < '0' || s[right] > '9'))
                    right--;

                if (s[left] != s[right])
                    return false;
                left++;
                right--;
            }

            return true;
        }
    }
}
