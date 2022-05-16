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

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (dic.ContainsKey(nums[i]))
            //        dic[nums[i]]++;
            //    else
            //        dic.Add(nums[i], 1);

            //    if (dic[nums[i]] > nums.Length / 2) return nums[i];
            //}

            return -1;
        }
    }
}
