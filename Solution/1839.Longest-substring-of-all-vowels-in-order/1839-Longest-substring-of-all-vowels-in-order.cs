using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1839.Longest_substring_of_all_vowels_in_order
{
    public class _1839_Longest_substring_of_all_vowels_in_order
    {
        public int LongestBeautifulSubstring(string word)
        {
            List<char> lists = new List<char>();
            lists.Add('a');
            lists.Add('e');
            lists.Add('i');
            lists.Add('o');
            lists.Add('u');

            int index = 0;
            int len = 0;
            int max = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == lists[index])
                    len++;
                else if ((len > 0) && (index + 1 < lists.Count) && (word[i] == lists[index + 1]))
                {
                    index++;
                    len++;
                }
                else
                {
                    if (index == 4)
                    {
                        if (len > max)
                            max = len;
                    }

                    index = 0;
                    len = 0;

                    if (word[i] == lists[0])
                        len = 1;
                }
            }

            if (index == 4)
            {
                if (len > max)
                    max = len;
            }

            return max;
        }
    }
}
