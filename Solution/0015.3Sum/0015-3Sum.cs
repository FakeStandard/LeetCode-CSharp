using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solution._0015._3Sum
{
    public class _0015_3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();

            if (nums.Length < 3) return res;

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

            //
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            List<int> list = new List<int>();
                            list.Add(nums[i]);
                            list.Add(nums[j]);
                            list.Add(nums[k]);

                            if (Traverse(res, list))
                                res.Add(list);
                        }
                    }
                }
            }

            return res;
        }

        private bool Traverse(IList<IList<int>> res, List<int> list)
        {
            for (int i = 0; i < res.Count; i++)
            {
                //if (res[i][0] == list[0] && res[i][1] == list[1] && res[i][2] == list[2]) return false;

                // linq
                if (Enumerable.SequenceEqual(res[i], list)) return false;
            }

            return true;
        }
    }
}
