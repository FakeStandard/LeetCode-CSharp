using System;

namespace _1869.Longer_contiguous_segments_of_ones_than_zeros
{
    public class Solution
    {
        public bool CheckZeroOnes(string s)
        {
            int a = 0;
            int b = 0;
            int a_Max = 0;
            int b_Max = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0')
                {
                    if (b > b_Max)
                        b_Max = b;
                    b = 0;
                    a++;
                }
                else
                {
                    if (a > a_Max)
                        a_Max = a;
                    a = 0;
                    b++;
                }
            }

            if (a > a_Max)
                a_Max = a;
            if (b > b_Max)
                b_Max = b;

            return a_Max < b_Max ? true : false;
        }
    }
}
