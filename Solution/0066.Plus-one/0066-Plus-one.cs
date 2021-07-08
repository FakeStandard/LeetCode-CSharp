using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0066.Plus_one
{
    public class _0066_Plus_one
    {
        public int[] PlusOne(int[] digits)
        {
            if (digits.Length == 0) return null;

            List<int> res = new List<int>();
            bool carry = false;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (i == digits.Length - 1)
                {
                    if (digits[i] + 1 == 10)
                    {
                        res.Add(0);
                        carry = true;
                    }
                    else
                        res.Add(digits[i] + 1);
                }
                else
                {
                    if (carry)
                    {
                        if (digits[i] + 1 == 10)
                        {
                            res.Add(0);
                            carry = true;
                        }
                        else
                        {
                            res.Add(digits[i] + 1);
                            carry = false;
                        }
                    }
                    else
                        res.Add(digits[i]);

                }
            }

            if (carry)
                res.Add(1);

            var r = res.ToArray();

            Array.Reverse(r);

            return r;
        }
    }
}
