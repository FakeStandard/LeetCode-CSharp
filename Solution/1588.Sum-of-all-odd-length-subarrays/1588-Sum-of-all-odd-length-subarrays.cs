using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1588.Sum_of_all_odd_length_subarrays
{
    public class _1588_Sum_of_all_odd_length_subarrays
    {
        public int SumOddLengthSubarrays(int[] arr)
        {
            int num = 0;

            for (int i = 1; i <= arr.Length; i += 2)
                for (int j = 0; j + i - 1 < arr.Length; j++)
                    for (int k = j; k < j + i; k++)
                        num += arr[k];

            return num;
        }
    }
}
