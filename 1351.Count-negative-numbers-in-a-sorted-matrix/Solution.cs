﻿using System;

namespace _1351.Count_negative_numbers_in_a_sorted_matrix
{
    public class Solution
    {
        public int CountNegatives(int[][] grid)
        {
            var count = 0;

            foreach (var arr in grid)
                foreach (var i in arr)
                    if (i < 0)
                        count++;

            return count;
        }
    }
}
