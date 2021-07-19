using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1832.Check_if_the_sentence_is_pangram
{
    public class _1832_Check_if_the_sentence_is_pangram
    {
        public bool CheckIfPangram(string sentence)
        {
            if (sentence.Length < 26) return false;

            Dictionary<char, bool> dic = new Dictionary<char, bool>();

            for (int i = 0; i < sentence.Length; i++)
            {
                if (!dic.ContainsKey(sentence[i]))
                    dic.Add(sentence[i], true);

                if (dic.Count == 26) return true;
            }

            return false;
        }
    }
}
