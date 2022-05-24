using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0043.Multiply_strings
{
    public class _0043_Multiply_strings
    {
        public string Multiply(string num1, string num2)
        {
            int[] res = new int[num1.Length + num2.Length];
            int digit = 0, carry = 0;
            Stack<int> stack = new Stack<int>();

            // Put the multiplication result into the corresponding column.
            for (int i = num1.Length - 1; i >= 0; i--)
                for (int j = num2.Length - 1; j >= 0; j--)
                    res[i + j] += (num1[i] - '0') * (num2[j] - '0');

            // Iterate over array and handle carry.
            for (int k = res.Length - 1; k >= 0; k--)
            {
                if (res[k] == 0 && k == res.Length - 1) continue;

                digit = res[k] % 10;
                carry = res[k] / 10;

                stack.Push(digit);

                // add carry to next.
                if (carry > 0)
                {
                    if (k == 0)
                        stack.Push(carry);
                    else
                        res[k - 1] += carry;
                }
            }

            // skip left zero
            var str = String.Join("", stack).TrimStart('0');
            if (str.Length == 0) return "0";

            return str;
        }
    }
}
