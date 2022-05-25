using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0997.Find_the_town_judge
{
    public class _0997_Find_the_town_judge
    {
        public int FindJudge(int n, int[][] trust)
        {
            // Use only one array.
            int[] res = new int[n + 1];

            foreach (int[] arr in trust)
            {
                res[arr[1]]++; // trusted
                res[arr[0]]--; // trusting
            }

            for (int i = 1; i <= n; i++)
                if (res[i] == n - 1)
                    return i;

            return -1;

            //Use dictionary, but use too much memory.
            //if (n == 1) return 1;

            //Dictionary<int, int> dic = new Dictionary<int, int>();

            //foreach (int[] arr in trust)
            //{
            //    if (dic.ContainsKey(arr[1]))
            //        dic[arr[1]]++;
            //    else
            //        dic.Add(arr[1], 1);

            //    if (dic.ContainsKey(arr[0]))
            //        dic[arr[0]]--;
            //    else
            //        dic.Add(arr[0], -1);
            //}

            //foreach (KeyValuePair<int, int> pair in dic)
            //{
            //    if (pair.Value == n - 1)
            //        return pair.Key;
            //}

            //return -1;
        }
    }
}
