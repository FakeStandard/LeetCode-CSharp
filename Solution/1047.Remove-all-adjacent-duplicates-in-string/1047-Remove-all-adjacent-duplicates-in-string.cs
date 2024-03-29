﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1047.Remove_all_adjacent_duplicates_in_string
{
    public class _1047_Remove_all_adjacent_duplicates_in_string
    {
        public string RemoveDuplicates(string s)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (sb.Length > 0 && s[i] == sb[sb.Length - 1])
                    sb.Remove(sb.Length - 1, 1);
                else
                    sb.Append(s[i]);
            }

            return sb.ToString();
        }
    }
}
