﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0728.Self_dividing_numbers
{
    public class _0728_Self_dividing_numbers
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            IList<int> res = new List<int>();

            while (left <= right)
            {
                int num = left;

                // 不允許包含零
                if (!(num % 10 == 0))
                {
                    while (num > 0)
                    {
                        int d = num % 10;

                        if (d == 0 || left % d != 0)
                            break;
                        num /= 10;
                    }

                    if (num == 0)
                        res.Add(left);
                }

                left++;
            }

            return res;
        }
    }
}
