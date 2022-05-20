using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0334.Increasing_triplet_subsequence
{
    public class _0334_Increasing_triplet_subsequence
    {
        public bool IncreasingTriplet(int[] nums)
        {
            if (nums.Length < 3) return false;

            int min = int.MaxValue;
            int mid = int.MaxValue;

            foreach (int num in nums)
            {
                if (num < min)
                    min = num;
                else if (num != min && num < mid)
                    mid = num;
                else if (num > mid)
                    return true;
            }

            return false;
        }
    }
}
