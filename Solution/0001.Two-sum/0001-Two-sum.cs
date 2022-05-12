using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    public class _0001_Two_sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            // 透過雙迴圈逐一走訪陣列
            // 因不可與本身計算, 故取 i+1 略過本身, 以及計算過的值

            int i, j;

            for (i = 0; i < nums.Length; i++)
                for (j = i + 1; j < nums.Length; j++)
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };

            return null;

            // 使用額外空間 Hash Table, 用空間換時間
            //Hashtable hash = new Hashtable();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int num = nums[i];
            //    int diff = target - num;

            //    if (hash.ContainsKey(diff))
            //        return new int[] { i, (int)hash[diff] };

            //    if (!hash.ContainsKey(num))
            //        hash.Add(num, i);
            //}

            //return null;

            // 改為使用額外空間 Dictionary, 用空間換時間
            // 且官方建議不再使用 Hash Table, 建議改為使用 Dictionary
            //Dictionary<int, int> dic = new Dictionary<int, int>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int num = nums[i];
            //    int diff = target - num;

            //    if (dic.ContainsKey(diff))
            //        return new int[] { i, (int)dic[diff] };

            //    if (!dic.ContainsKey(num))
            //        dic.Add(num, i);
            //}

            //return null;
        }
    }
}
