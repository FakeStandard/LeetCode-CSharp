using System;

namespace _1662.Check_if_two_string_arrays_are_equivalent
{
    public class Solution
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            return string.Join("", word1) == string.Join("", word2);

            //string res1=string.Empty;
            //string res2=string.Empty;

            //int i = 0;

            //for (i = 0; i < word1.Length; i++)
            //    res1 += word1[i];

            //for (i = 0; i < word2.Length; i++)
            //    res2 += word2[i];

            //return res1 == res2;
        }
    }
}
