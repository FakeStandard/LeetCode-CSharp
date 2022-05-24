using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0409.Longest_palindrome
{
    public class _0409_Longest_palindrome
    {
        public int LongestPalindrome(string s)
        {
            HashSet<char> set = new HashSet<char>();
            int count = 0;

            foreach (char c in s)
            {
                if (!set.Add(c))
                {
                    set.Remove(c);
                    count += 2;
                }
            }

            return set.Count > 0 ? ++count : count;

            // used more time.
            //Dictionary<char, int> dic = new Dictionary<char, int>();
            //int count = 0;

            //foreach (char c in s)
            //{
            //    if (dic.ContainsKey(c))
            //        dic[c]++;
            //    else
            //        dic.Add(c, 1);
            //}

            //bool odd = false;

            //foreach (var pair in dic)
            //{
            //    if (pair.Value >= 2)
            //    {
            //        if (pair.Value % 2 == 0)
            //            count += pair.Value;
            //        else
            //        {
            //            count += pair.Value - 1;
            //            odd = true;
            //        }
            //    }
            //    else odd = true;
            //}

            //if (odd) count++;

            //return count;
        }
    }
}
