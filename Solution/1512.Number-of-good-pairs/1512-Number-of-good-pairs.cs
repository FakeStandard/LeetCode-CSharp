using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1512.Number_of_good_pairs
{
    public class _1512_Number_of_good_pairs
    {
        public int NumIdenticalPairs(int[] nums)
        {
            int i, j, count = 0;

            for (i = 0; i < nums.Length; i++)
                for (j = i + 1; j < nums.Length; j++)
                    if (nums[i] == nums[j])
                        count++;

            return count;
        }
    }
}
