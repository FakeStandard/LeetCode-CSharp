using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1748.Sum_of_unique_elements
{
    public class _1748_Sum_of_unique_elements
    {
        public int SumOfUnique(int[] nums)
        {
            Dictionary<int, bool> dic = new Dictionary<int, bool>();

            foreach (var num in nums)
            {
                if (dic.ContainsKey(num))
                    dic[num] = false;
                else
                    dic.Add(num, true);
            }

            int sum = 0;

            foreach (var item in dic)
            {
                if (item.Value)
                    sum += item.Key;
            }

            return sum;
        }
    }
}
