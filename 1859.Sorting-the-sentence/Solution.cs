using System;
using System.Collections.Generic;
using System.Text;

namespace _1859.Sorting_the_sentence
{
    public class Solution
    {
        public string SortSentence(string s)
        {
            string[] arr = s.Split(" ");
            string[] res = new string[arr.Length];

            foreach (string str in arr)
            {
                // The ASCII character ‘0’ is represented by 48 (decimal)
                int index = str[str.Length - 1] - '0' - 1;

                res[index] = str.Substring(0, str.Length - 1);
            }

            return String.Join(' ', res);
        }
    }
}
