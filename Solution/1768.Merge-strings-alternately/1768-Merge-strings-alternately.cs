using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1768.Merge_strings_alternately
{
    public class _1768_Merge_strings_alternately
    {
        public string MergeAlternately(string word1, string word2)
        {
            int i = 0, j = 0;
            string res = "";

            while (i < word1.Length || j < word2.Length)
            {
                if (i < word1.Length)
                    res += word1[i++];
                if (j < word2.Length)
                    res += word2[j++];
            }

            return res;
        }
    }
}
