using System;

namespace _0344.Reverse_string
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            // Solution 1
            //Array.Reverse(s);

            // Soluton 2
            int i = 0, j = s.Length - 1;
            char tmp;

            while (i < j)
            {
                tmp = s[i];
                s[i] = s[j];
                s[j] = tmp;

                i++;
                j--;
            }
        }
    }
}
