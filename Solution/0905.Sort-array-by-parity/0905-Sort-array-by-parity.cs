using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0905.Sort_array_by_parity
{
    public class _0905_Sort_array_by_parity
    {
        public int[] SortArrayByParity(int[] nums)
        {
            int[] res = new int[nums.Length];
            int head = 0, tail = nums.Length - 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    res[head] = nums[i];
                    head++;
                }
                else
                {
                    res[tail] = nums[i];
                    tail--;
                }
            }

            return res;
        }
    }
}
