using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0347.Top_k_frequent_elements
{
    public class _0347_Top_k_frequent_elements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            if (nums.Length == 1) return nums;

            var dic = new Dictionary<int, int>();
            var res = new int[k];

            // record the number of occurrences of each element.
            foreach (int num in nums)
                if (!dic.TryAdd(num, 1))
                    dic[num]++;

            int max = int.MinValue;
            int i = 0;

            // Iterate k times to find the number displayed the most times.
            while (i < k)
            {
                foreach (KeyValuePair<int, int> pair in dic)
                {
                    if (max == int.MinValue)
                        max = pair.Key;
                    else if (pair.Value > dic[max])
                        max = pair.Key;
                }

                res[i] = max;
                dic.Remove(max);
                max = int.MinValue;

                i++;
            }

            return res;
        }
    }
}
