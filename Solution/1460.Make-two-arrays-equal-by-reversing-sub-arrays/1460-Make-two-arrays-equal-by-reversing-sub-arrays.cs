using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1460.Make_two_arrays_equal_by_reversing_sub_arrays
{
    public class _1460_Make_two_arrays_equal_by_reversing_sub_arrays
    {
        public bool CanBeEqual(int[] target, int[] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (var i in target)
            {
                if (dic.ContainsKey(i))
                    dic[i]++;
                else
                    dic.Add(i, 1);
            }

            foreach (var j in arr)
            {
                if (!dic.ContainsKey(j))
                    return false;
                else if (dic[j] == 0)
                    return false;
                else
                    dic[j]--;
            }

            //for (int i = 0; i < target.Length; i++)
            //{
            //    // target
            //    if (dic.ContainsKey(target[i]))
            //        dic[target[i]]++;
            //    else
            //        dic.Add(target[i], 1);

            //    // arr
            //    if (dic.ContainsKey(arr[i]))
            //        dic[arr[i]]--;
            //    else
            //        dic.Add(arr[i], -1);

            //    // remove
            //    if (dic[target[i]] == 0)
            //        dic.Remove(target[i]);

            //    if (dic.ContainsKey(arr[i]) && dic[arr[i]] == 0)
            //        dic.Remove(arr[i]);
            //}

            //return true;

            return dic.Count == 0;
        }
    }
}
