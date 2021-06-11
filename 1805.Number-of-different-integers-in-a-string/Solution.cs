using System;
using System.Collections.Generic;
using System.Text;

namespace _1805.Number_of_different_integers_in_a_string
{
    public class Solution
    {
        public int NumDifferentIntegers(string word)
        {
            HashSet<string> set = new HashSet<string>();

            int i = 0;

            while (i < word.Length)
            {
                if (word[i] >= 'a' && word[i] <= 'z')
                {
                    i++;
                    continue;
                }

                StringBuilder sb = new StringBuilder();

                while ((i < word.Length) && (word[i] >= '0') && (word[i] <= '9'))
                    sb.Append(word[i++]);

                set.Add(sb.ToString().TrimStart('0'));
            }

            return set.Count;

            //StringBuilder sb = new StringBuilder();

            //List<string> list = new List<string>();

            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] >= '0' && word[i] <= '9')
            //        sb.Append(word[i]);
            //    else
            //    {
            //        if (sb.ToString() != string.Empty)
            //        {
            //            string str = sb.ToString().TrimStart('0');

            //            if (!list.Contains(str))
            //                list.Add(str);

            //            sb.Clear();
            //        }
            //    }
            //}

            //if (sb.ToString() != string.Empty)
            //{
            //    string str = sb.ToString().TrimStart('0');

            //    if (!list.Contains(str))
            //        list.Add(str);
            //}

            //return list.Count;
        }
    }
}
