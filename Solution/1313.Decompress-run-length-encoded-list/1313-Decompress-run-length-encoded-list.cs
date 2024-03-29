﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1313.Decompress_run_length_encoded_list
{
    public class _1313_Decompress_run_length_encoded_list
    {
        public int[] DecompressRLElist(int[] nums)
        {
            List<int> res = new List<int>();

            for (int i = 0; i < nums.Length; i += 2)
                for (int j = 0; j < nums[i]; j++)
                    res.Add(nums[i + 1]);

            return res.ToArray();
        }
    }
}
