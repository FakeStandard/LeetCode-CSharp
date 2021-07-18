using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1816.Truncate_sentence
{
    public class _1816_Truncate_sentence
    {
        public string TruncateSentence(string s, int k)
        {
            string[] str = s.Split(' ');
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < k; i++)
                sb.Append(str[i] + " ");

            return sb.ToString().Trim();

            //string[] str1 = s.Split(' ');

            //string[] str2 = new string[k];

            //for (int i = 0; i < k; i++)
            //    str2[i] = str1[i];

            //return String.Join(" ", str2);
        }
    }
}
