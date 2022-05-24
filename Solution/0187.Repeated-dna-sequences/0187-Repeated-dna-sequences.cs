using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0187.Repeated_dna_sequences
{
    public class _0187_Repeated_dna_sequences
    {
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            List<string> res = new List<string>();

            if (s.Length <= 10) return res;

            HashSet<string> set = new HashSet<string>();

            string tmp = "";
            for (int i = 0; i < s.Length - 9; i++)
            {
                tmp = s.Substring(i, 10);

                if (!set.Add(tmp))
                    if (!res.Contains(tmp))
                        res.Add(tmp);
            }

            return res;
        }
    }
}
