using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1684.Count_the_number_of_consistent_strings
{
    public class _1684_Count_the_number_of_consistent_strings
    {
        public int CountConsistentStrings(string allowed, string[] words)
        {
            int count = 0;

            for (int i = 0; i < words.Length; i++)
            {
                foreach (var word in words[i])
                {
                    if (!allowed.Contains(word))
                    {
                        count++;
                        break;
                    }
                }
            }

            return words.Length - count;
        }
    }
}
