using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1221.Split_a_string_in_balanced_strings
{
    public class _1221_Split_a_string_in_balanced_strings
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
