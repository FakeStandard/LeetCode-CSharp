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

            backtrack(s, 0);

            return res;
        }

        private void backtrack(string str, int index)
        {
            
        }
    }
}
