﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1480.Running_sum_of_1d_array
{
    public class _1480_Running_sum_of_1d_array
    {
        public int[] RunningSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
                nums[i] = nums[i] + nums[i - 1];

            return nums;
        }

        /// <summary>
        /// The first thought
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        //public int[] RunningSum(int[] nums)
        //{
        //    int i, j, tmp;
        //    int[] result = new int[nums.Length];

        //    for (i = 0; i < nums.Length; i++)
        //    {
        //        tmp = 0;

        //        for (j = 0; j <= i; j++)
        //            tmp = tmp + nums[j];

        //        result[i] = tmp;
        //    }

        //    return result;
        //}
    }
}
