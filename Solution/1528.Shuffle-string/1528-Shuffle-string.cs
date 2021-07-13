using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1528.Shuffle_string
{
    public class _1528_Shuffle_string
    {
        public string RestoreString(string s, int[] indices)
        {
            if (string.IsNullOrWhiteSpace(s)) return null;

            char[] res = new char[s.Length];

            for (int i = 0; i < indices.Length; i++)
                res[indices[i]] = s[i];

            return new string(res);
        }
    }
}
