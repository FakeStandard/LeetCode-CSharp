using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0167.Two_sum_II_input_array_is_sorted
{
    public class _0167_Two_sum_II_input_array_is_sorted
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                if (numbers[left] + numbers[right] == target)
                    return new int[] { left + 1, right + 1 };

                if (numbers[left] + numbers[right] < target)
                    left++;
                else
                    right--;
            }

            return new int[] { left + 1, right + 1 };

            // Time Limit Exceeded
            //// 逐一取得每個元素
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    // 依照取得元素的索引，與索引後的陣列
            //    for (int j = i + 1; j < numbers.Length; j++)
            //    {
            //        if (numbers[i] + numbers[j] == target)
            //            return new int[] { i + 1, j + 1 };
            //    }
            //}

            //throw new Exception("No two sum solution.");
        }
    }
}
