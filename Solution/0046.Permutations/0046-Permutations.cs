using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0046.Permutations
{
    public class _0046_Permutations
    {
        IList<IList<int>> res = new List<IList<int>>();

        public IList<IList<int>> Permute(int[] nums)
        {
            var list = new List<int>();

            backtrack(list, nums);

            return res;
        }

        private void backtrack(List<int> list, int[] nums)
        {
            List<int> temp = null;

            if (list.Count != nums.Length)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (!list.Contains(nums[i]))
                    {
                        temp = new List<int>(list);
                        temp.Add(nums[i]);
                        backtrack(temp, nums);
                    }
                }
            }
            else res.Add(list);
        }
    }
}
