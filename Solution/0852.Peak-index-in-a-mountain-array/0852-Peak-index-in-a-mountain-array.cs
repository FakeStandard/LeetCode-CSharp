using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0852.Peak_index_in_a_mountain_array
{
    public class _0852_Peak_index_in_a_mountain_array
    {
        public int PeakIndexInMountainArray(int[] arr)
        {
            int count = 0;

            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > arr[i - 1])
                    count++;

            return count;
        }
    }
}
