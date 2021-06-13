using System;

namespace _1684.Count_the_number_of_consistent_strings
{
    public class Solution
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
