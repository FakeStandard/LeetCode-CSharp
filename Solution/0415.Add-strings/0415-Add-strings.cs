using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solution._0415.Add_strings
{
    public class _0415_Add_strings
    {
        public string AddStrings(string num1, string num2)
        {
            StringBuilder sb = new StringBuilder();

            int i = num1.Length - 1;
            int j = num2.Length - 1;
            int sum = 0;
            int n1 = 0;
            int n2 = 0;
            int carry = 0;

            while (i >= 0 || j >= 0 || carry == 1)
            {
                sum = 0;
                n1 = 0;
                n2 = 0;

                n1 = i < 0 ? 0 : num1[i] - '0';
                n2 = j < 0 ? 0 : num2[j] - '0';

                sum = n1 + n2 + carry;
                sb.Append(sum % 10);

                carry = sum / 10;

                i--;
                j--;
            }

            return new string(sb.ToString().Reverse().ToArray());
        }
    }
}
