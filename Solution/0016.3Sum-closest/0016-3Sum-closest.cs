using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0016._3Sum_closest
{
    public class _0016_3Sum_closest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            // Solution 1
            //Array.Sort(nums);

            // bubble sort
            int tmp = 0;
            int flag = 0;

            for (int i = nums.Length - 1; i > 0; i--)
            {
                flag = 0;

                for (int j = 0; j < i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        // swap
                        tmp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = tmp;

                        flag++;
                    }
                }

                if (flag == 0) break;
            }

            int left = 0;
            int right = 0;
            int sum = 0;
            int diff = 0;
            int closer = int.MaxValue;
            int res = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                left = i + 1;
                right = nums.Length - 1;

                while (left < right)
                {
                    sum = nums[i] + nums[left] + nums[right];

                    if (sum == target)
                        return sum;
                    if (sum < target)
                        left++;
                    if (sum > target)
                        right--;

                    diff = Math.Abs(target - sum);

                    if (closer > diff)
                    {
                        closer = diff;
                        res = sum;
                    }
                }
            }

            return res;

            // Solution 2
            //if (nums.Length == 3) return nums[0] + nums[1] + nums[2];

            //int diff = 0, res = 0, sum = 0;
            //int tmp = int.MaxValue;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        for (int k = j + 1; k < nums.Length; k++)
            //        {
            //            sum = nums[i] + nums[j] + nums[k];
            //            if (sum == target)
            //                return sum;

            //            diff = Math.Abs(sum - target);

            //            if (diff < tmp)
            //            {
            //                tmp = diff;
            //                res = sum;
            //            }
            //        }
            //    }
            //}

            //return res;
        }
    }
}
