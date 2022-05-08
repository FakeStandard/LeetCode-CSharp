using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0383.Ransom_note
{
    public class _0383_Ransom_note
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (char c in magazine)
            {
                if (dic.ContainsKey(c))
                    dic[c]++;
                else
                    dic.Add(c, 1);
            }

            foreach(char c in ransomNote)
            {
                if (dic.ContainsKey(c))
                    dic[c]--;
                else return false;
                if (dic[c] == -1) return false;
            }

            return true;
        }
    }
}
