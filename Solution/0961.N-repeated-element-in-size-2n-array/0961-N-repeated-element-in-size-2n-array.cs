using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0961.N_repeated_element_in_size_2n_array
{
    public class _0961_N_repeated_element_in_size_2n_array
    {
        public int RepeatedNTimes(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i])) return nums[i];

                dic.Add(nums[i], 0);
            }

            return -1;
        }
    }
}
