﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _1796.Second_largest_digit_in_a_string
{
    public class Solution
    {
        public int SecondHighest(string s)
        {
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                    set.Add(s[i] - '0');
            }

            if (set.Count <= 1) return -1;

            set.Remove(set.Max());

            return set.Max();

            #region Solution 1
            //HashSet<int> set = new HashSet<int>();

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] >= '0' && s[i] <= '9')
            //        set.Add(s[i] - '0');
            //}

            //if (set.Count <= 1) return -1;

            //int first = 0;
            //int second = 0;

            //foreach (var item in set)
            //{
            //    if (item > first)
            //    {
            //        second = first;
            //        first = item;
            //    }
            //    else if (item < first && item > second)
            //        second = item;
            //}

            //return second;
            #endregion

            #region Solution 2
            //int first = -1;
            //int second = -1;

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (char.IsDigit(s[i]) && s[i] - '0' > first)
            //    {
            //        second = first;
            //        first = s[i] - '0';
            //    }
            //    else if (char.IsDigit(s[i]) && s[i] - '0' > second && s[i] - '0' < first)
            //        second = s[i] - '0';
            //}

            //return second;
            #endregion
        }
    }
}
