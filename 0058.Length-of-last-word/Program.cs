using System;

namespace _0058.Length_of_last_word
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int r;

            // Ex1
            s = "Hello World";
            r = LengthOfLastWord(s);
            Console.WriteLine(r);

            // Ex2
            s = " ";
            r = LengthOfLastWord(s);
            Console.WriteLine(r);

            s = "a ";
            r = LengthOfLastWord(s);
            Console.WriteLine(r);

            Console.ReadLine();
        }

        /// <summary>
        /// 找出字串中最後一個單字的長度
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LengthOfLastWord(string s)
        {
            string[] words = s.Trim().Split(' ');

            return words[words.Length - 1].Length;
        }
    }
}
