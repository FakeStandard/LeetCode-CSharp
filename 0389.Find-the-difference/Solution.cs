using System;

namespace _0389.Find_the_difference
{
    public class Solution
    {
        public char FindTheDifference(string s, string t)
        {
            int sum = 0;

            foreach (char c1 in s)
                sum ^= c1;

            foreach (char c2 in t)
                sum ^= c2;

            return (char)sum;
        }
    }
}
