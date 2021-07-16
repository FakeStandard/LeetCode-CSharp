using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1790.Check_if_one_string_swap_can_make_strings_equal
{
    public class _1790_Check_if_one_string_swap_can_make_strings_equal
    {
        public bool AreAlmostEqual(string s1, string s2)
        {
            if (s1 == s2) return true;

            int firstIndex = -1;
            int secondIndex = -1;

            char[] c = s1.ToCharArray();

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] != s2[i] && firstIndex == -1)
                    firstIndex = i;
                else if (c[i] != s2[i] && secondIndex == -1)
                    secondIndex = i;
                else if (firstIndex != -1 && secondIndex != -1)
                    break;
            }

            if (firstIndex == -1 || secondIndex == -1) return false;

            char temp;

            temp = c[firstIndex];
            c[firstIndex] = c[secondIndex];
            c[secondIndex] = temp;

            return new string(c) == s2;
        }
    }
}
