using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0169.Majority_element
{
    public class _0169_Majority_element
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (dic.ContainsKey(num))
                    dic[num]++;
                else
                    dic.Add(num, 1);

                if (dic[num] > nums.Length / 2)
                    return num;
            }

            return -1;
        }
    }
}
