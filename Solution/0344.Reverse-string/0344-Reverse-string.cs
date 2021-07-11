using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0344.Reverse_string
{
    public class _0344_Reverse_string
    {
        /// <summary>
        /// Soluton 2
        /// </summary>
        /// <param name="s"></param>
        public void ReverseString(char[] s)
        {
            int i = 0, j = s.Length - 1;
            char tmp;

            while (i < j)
            {
                tmp = s[i];
                s[i] = s[j];
                s[j] = tmp;

                i++;
                j--;
            }
        }

        /// <summary>
        /// Solution 1
        /// </summary>
        /// <param name="s"></param>
        //public void ReverseString(char[] s)
        //{
        //    Array.Reverse(s);
        //}
    }
}
