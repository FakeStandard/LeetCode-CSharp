﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1365.How_many_numbers_are_smaller_than_current_number
{
    public class _1365_How_many_numbers_are_smaller_than_current_number
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int i, j;
            int count;
            int[] result = new int[nums.Length];

            for (i = 0; i < result.Length; i++)
            {
                count = 0;

                for (j = 0; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i])
                        count++;
                }

                result[i] = count;
            }

            return result;
        }
    }
}
