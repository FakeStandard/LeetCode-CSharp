using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1295.Find_numbers_with_even_number_of_digits
{
    public class _1295_Find_numbers_with_even_number_of_digits
    {
        public int FindNumbers(int[] nums)
        {
            int count = 0;

            // approach 1
            //for (int i = 0; i < nums.Length; i++)
            //    if (nums[i].ToString().Length % 2 == 0)
            //        count++;

            for (int i = 0; i < nums.Length; i++)
            {
                int q = nums[i];
                int num = 0;

                while (q != 0)
                {
                    q /= 10;
                    num++;
                }

                if (num % 2 == 0) count++;
            }

            return count;
        }
    }
}
