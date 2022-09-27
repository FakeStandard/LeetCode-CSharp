using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0066.Plus_one
{
    public class _0066_Plus_one
    {
        public int[] PlusOne(int[] digits)
        {
            List<int> list = new List<int>();
            bool carry = false;

            int len = digits.Length - 1;

            if (digits[len] + 1 == 10)
            {
                list.Add(0);
                carry = true;
            }
            else list.Add(digits[len] + 1);

            for (int i = len - 1; i >= 0; i--)
            {
                if (carry)
                {
                    if (digits[i] + 1 == 10)
                        list.Add(0);
                    else
                    {
                        list.Add(digits[i] + 1);
                        carry = false;
                    }
                }
                else list.Add(digits[i]);
            }

            if (carry) list.Add(1);

            var res = list.ToArray();
            Array.Reverse(res);

            return res;
        }
    }
}
