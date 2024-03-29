﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1827.Minimum_operations_to_make_the_array_increasing
{
    public class _1827_Minimum_operations_to_make_the_array_increasing
    {
        public int MinOperations(int[] nums)
        {
            int count = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] >= nums[i])
                {
                    int add = nums[i - 1] - nums[i] + 1;
                    nums[i] += add;
                    count += add;
                }
            }

            return count;

            //int count = 0;

            //for(int i = 1; i < nums.Length; i++)
            //{
            //    while(nums[i - 1] >= nums[i])
            //    {
            //        nums[i]++;
            //        count++;
            //    }
            //}

            //return count;
        }
    }
}
