using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1880.Check_if_word_equals_summation_of_two_words
{
    public class _1880_Check_if_word_equals_summation_of_two_words
    {
        public bool IsSumEqual(string firstWord, string secondWord, string targetWord)
        {
            int i = 0;
            StringBuilder s1 = new StringBuilder();
            StringBuilder s2 = new StringBuilder();
            StringBuilder s3 = new StringBuilder();

            for (i = 0; i < firstWord.Length; i++)
                s1.Append(firstWord[i] - 'a');

            for (i = 0; i < secondWord.Length; i++)
                s2.Append(secondWord[i] - 'a');

            for (i = 0; i < targetWord.Length; i++)
                s3.Append(targetWord[i] - 'a');

            return int.Parse(s1.ToString()) + int.Parse(s2.ToString()) == int.Parse(s3.ToString()) ? true : false;
        }
    }
}
