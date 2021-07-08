using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0058.Length_of_last_word
{
    public class _0058_Length_of_last_word
    {
        public int LengthOfLastWord(string s)
        {
            string[] words = s.Trim().Split(' ');

            return words[words.Length - 1].Length;
        }
    }
}
