using System;

namespace _1221.Split_a_string_in_balanced_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int BalancedStringSplit(string s)
        {
            int num = 0;
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'L')
                    num++;
                else
                    num--;
                if (num == 0)
                {
                    count++;
                    num = 0;
                }
            }

            return count;
        }
    }
}
