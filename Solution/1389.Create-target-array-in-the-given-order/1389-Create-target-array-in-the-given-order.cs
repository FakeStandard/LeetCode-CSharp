using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1389.Create_target_array_in_the_given_order
{
    public class _1389_Create_target_array_in_the_given_order
    {
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            List<int> res = new List<int>();

            for (int i = 0; i < nums.Length; i++)
                res.Insert(index[i], nums[i]);

            return res.ToArray();
        }
    }
}
