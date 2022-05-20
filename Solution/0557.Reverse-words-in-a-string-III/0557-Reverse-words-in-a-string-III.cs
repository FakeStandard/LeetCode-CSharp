using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0557.Reverse_words_in_a_string_III
{
    public class _0557_Reverse_words_in_a_string_III
    {
        public string ReverseWords(string s)
        {
            string[] arr = s.Split(" ");
            char tmp;
            int left = 0, right = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                left = 0;
                right = arr[i].Length - 1;

                var word = arr[i].ToCharArray();

                while (left < right)
                {
                    tmp = word[left];
                    word[left] = word[right];
                    word[right] = tmp;

                    left++;
                    right--;
                }

                arr[i] = new string(word);
            }

            return string.Join(" ", arr);
        }
    }
}
