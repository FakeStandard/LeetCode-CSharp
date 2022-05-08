using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Solution._0350.Intersection_of_two_arraysII
{
    public class _0350_Intersection_of_two_arraysII
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> lists = new List<int>();

            for(int i = 0; i < nums1.Length; i++)
            {
                for(int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        nums2[j] = -1;
                        lists.Add(nums1[i]);
                        break;
                    }
                }
            }

            return lists.ToArray();
        }
    }
}
