using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0049.Group_anagrams
{
    public class _0049_Group_anagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> res = new List<IList<string>>();
            if (strs.Length == 0) return res;

            IList<int[]> list = new List<int[]>();
            bool flag = false;

            foreach (string str in strs)
            {
                flag = false;
                int[] arr = new int[26];

                for (int i = 0; i < str.Length; i++)
                    arr[str[i] - 97]++;

                // compare
                for (int i = 0; i < list.Count; i++)
                {
                    if (AreEqual(list[i], arr))
                    {
                        res[i].Add(str);
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    list.Add(arr);
                    res.Add(new List<string>() { str });
                }
            }

            return res;
        }

        private bool AreEqual(int[] s1, int[] s2)
        {
            if (s1.Length != s2.Length) return false;

            for (int i = 0; i < s1.Length; i++)
                if (s1[i] != s2[i]) return false;

            return true;
        }
    }
}
