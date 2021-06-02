using System;
using System.Collections.Generic;

namespace _1859.Sorting_the_sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string res;
            string[] lists = { "is2 sentence4 This1 a3", "Myself2 Me1 I4 and3" };

            Solution s = new Solution();

            foreach (string item in lists)
            {
                Console.WriteLine($"[{item}] ");

                res = s.SortSentence(item);

                Console.WriteLine($"[{res}] ");
            }

            Console.ReadLine();
        }

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
}
