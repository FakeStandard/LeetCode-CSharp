using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solution._0567.Permutation_in_string
{
    public class _0567_Permutation_in_string
    {
        public bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length) return false;
            if (s1.Length == 0 || s1 == s2) return true;

            int[] arr1 = new int[26];
            int[] arr2 = new int[26];

            for (int i = 0; i < s1.Length; i++)
            {
                arr1[s1[i] - 97]++;
                arr2[s2[i] - 97]++;
            }

            if (AreEqual(arr1, arr2)) return true;

            for (int i = s1.Length; i < s2.Length; i++)
            {
                arr2[s2[i] - 97]++;
                arr2[s2[i - s1.Length] - 97]--;

                if (AreEqual(arr1, arr2)) return true;
            }

            return false;
        }

        private bool AreEqual(int[] s1, int[] s2)
        {
            for (int i = 0; i < s1.Length; i++)
                if (s1[i] != s2[i])
                    return false;

            return true;
        }
    }
}
