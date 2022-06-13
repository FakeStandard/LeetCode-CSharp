using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1207.Unique_number_of_occurrences
{
    public class _1207_Unique_number_of_occurrences
    {
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i]))
                    dic[arr[i]]++;
                else
                    dic.Add(arr[i], 1);
            }

            HashSet<int> set = new HashSet<int>();

            foreach (KeyValuePair<int, int> pair in dic)
            {
                if (set.Contains(pair.Value))
                    return false;
                else
                    set.Add(pair.Value);
            }

            return true;
        }
    }
}
