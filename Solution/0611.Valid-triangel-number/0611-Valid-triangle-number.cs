using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0611.Valid_triangel_number
{
    public class _0611_Valid_triangle_number
    {
        /// <summary>
        /// Binary Search
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int TriangleNumber(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            Array.Sort(nums);

            int left = 0, right = 0;
            int count = 0;

            for (int i = nums.Length - 1; i >= 2; i--)
            {
                left = 0;
                right = i - 1;

                while (left < right)
                {
                    if (nums[left] + nums[right] > nums[i])
                    {
                        count += right - left;
                        right--;
                    }
                    else
                        left++;
                }
            }

            return count;
        }

        /// <summary>
        /// Iteration - Time Limit Exceeded
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        //public int TriangleNumber(int[] nums)
        //{
        //    Array.Sort(nums);
        //    int count = 0;

        //    for (int i = 0; i < nums.Length - 2; i++)
        //    {
        //        for (int j = i + 1; j < nums.Length - 1; j++)
        //        {
        //            for (int k = j + 1; k < nums.Length; k++)
        //            {
        //                if (nums[i] + nums[j] <= nums[k])
        //                    break;
        //                count++;
        //            }
        //        }
        //    }

        //    return count;
        //}
    }
}
