using System;

namespace _0344.Reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            // ex1
            char[] s1 = { 'h', 'e', 'l', 'l', 'o' };
            s.ReverseString(s1);

            // ex2
            char[] s2 = { 'H', 'a', 'n', 'n', 'a', 'h' };
            s.ReverseString(s2);

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public void ReverseString(char[] s)
        {
            //Array.Reverse(s);

            int i = 0, j = s.Length - 1;
            char temp;

            while (i <= j)
            {
                temp = s[j];
                s[j] = s[i];
                s[i] = temp;

                i++;
                j--;
            }

            foreach (char c in s)
                Console.Write($"{c} ");
        }
    }
}
