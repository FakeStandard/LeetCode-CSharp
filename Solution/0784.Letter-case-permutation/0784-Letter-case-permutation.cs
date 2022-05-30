using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0784.Letter_case_permutation
{
    public class _0784_Letter_case_permutation
    {
        IList<string> res = new List<string>();

        public IList<string> LetterCasePermutation(string s)
        {
            if (s == null || s.Length == 0) return res;

            res.Add(s);
            backtrack(s.ToCharArray(), 0);

            return res;
        }

        private void backtrack(char[] str, int index)
        {
            if (index == str.Length) return;

            bool lower = str[index] >= 'a' && str[index] <= 'z';
            bool upper = str[index] >= 'A' && str[index] <= 'Z';

            // is letter
            if (lower || upper)
            {
                var temp = str[index];
                backtrack(str, index + 1);

                str[index] = lower ? (char)(str[index] - 32) : (char)(str[index] + 32);
                backtrack(str, index + 1);

                res.Add(new string(str));
                str[index] = temp;
            }
            else // is digit
                backtrack(str, index + 1);
        }
    }
}
