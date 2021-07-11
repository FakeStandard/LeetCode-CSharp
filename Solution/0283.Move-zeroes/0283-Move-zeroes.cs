using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0283.Move_zeroes
{
    public class _0283_Move_zeroes
    {
        public void MoveZeroes(int[] nums)
        {
            int curr = 0;
            int next = 1;

            while (next <= nums.Length - 1)
            {
                if (nums[curr] == 0)
                {
                    if (nums[next] == 0)
                    {
                        next++;
                        continue;
                    }
                    else
                    {
                        nums[curr] = nums[next];
                        nums[next] = 0;
                    }
                }

                curr++;
                next++;
            }
        }
    }
}
