using System;
using System.Collections.Generic;
using System.Linq;

namespace _0169.Majority_element
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            int max = int.MinValue;
            int key = 0;

            foreach (int num in nums)
            {
                if (dic.ContainsKey(num))
                    dic[num]++;
                else
                    dic.Add(num, 1);

                if (dic[num] > max)
                {
                    max = dic[num];
                    key = num;
                }
            }

            return key;
        }
    }
}
