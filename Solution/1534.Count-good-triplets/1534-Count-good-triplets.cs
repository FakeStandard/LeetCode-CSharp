using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1534.Count_good_triplets
{
    public class _1534_Count_good_triplets
    {
        public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) > a) continue;

                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (Math.Abs(arr[j] - arr[k]) > b) continue;
                        if (Math.Abs(arr[i] - arr[k]) > c) continue;

                        count++;
                    }
                }
            }

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (Math.Abs(arr[i] - arr[j]) <= a)
            //        {
            //            for (int k = j + 1; k < arr.Length; k++)
            //            {
            //                if (Math.Abs(arr[j] - arr[k]) <= b)
            //                {
            //                    if (Math.Abs(arr[i] - arr[k]) <= c)
            //                    {
            //                        count++;
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}

            return count;
        }
    }
}
