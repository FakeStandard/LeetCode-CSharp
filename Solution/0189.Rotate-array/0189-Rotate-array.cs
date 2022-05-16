using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0189.Rotate_array
{
    public class _0189_Rotate_array
    {
        public void Rotate(int[] nums, int k)
        {

            // additional memory
            //int[] res = new int[nums.Length];
            //int len = nums.Length;

            //for (int i = 0; i < len; i++)
            //    res[(i + k) % len] = nums[i];

            //for (int j = 0; j < len; j++)
            //    nums[j] = res[j];

            // without using any additional memory
            if (nums.Length < 2) return;

            // ex: 1 2 3 4 5 6 7
            k %= nums.Length;

            // reverse all, result: 7 6 5 4 3 2 1 
            Reverse(nums, 0, nums.Length - 1);

            // reverse 0~k-1, result: 5 6 7 4 3 2 1 
            Reverse(nums, 0, k - 1);

            // reverse k~nums.length-1
            Reverse(nums, k, nums.Length - 1);
        }

        private void Reverse(int[] nums, int l, int r)
        {
            int tmp;

            while (l < r)
            {
                // swap
                tmp = nums[l];
                nums[l] = nums[r];
                nums[r] = tmp;

                l++;
                r--;
            }
        }
    }
}
