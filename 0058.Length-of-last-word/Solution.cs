using System;

namespace _0058.Length_of_last_word
{
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            string[] words = s.Trim().Split(' ');

            return words[words.Length - 1].Length;
        }
    }
}
