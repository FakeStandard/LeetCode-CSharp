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
            // Solution 2
            bool carry = false;
            int i = num1.Length - 1;
            int j = num2.Length - 1;
            int x = 0, y = 0, sum = 0;
            string tmp = "", res = "";

            while (true)
            {
                if (i < 0 && j < 0) break;

                x = i < 0 ? 0 : num1[i] - '0';
                y = j < 0 ? 0 : num2[j] - '0';

                sum = carry ? x + y + 1 : x + y;
                if (sum / 10 == 1)
                {
                    carry = true;
                    sum %= 10;
                }
                else carry = false;

                tmp += sum;

                i--;
                j--;
            }

            if (carry) tmp += 1;

            // reverse
            for (int k = tmp.Length - 1; k >= 0; k--)
                res += tmp[k];

            return res;

            // Solution 1
            //StringBuilder sb = new StringBuilder();

            //int i = num1.Length - 1;
            //int j = num2.Length - 1;
            //int sum = 0;
            //int n1 = 0;
            //int n2 = 0;
            //int carry = 0;

            //while (i >= 0 || j >= 0 || carry == 1)
            //{
            //    sum = 0;
            //    n1 = 0;
            //    n2 = 0;

            //    n1 = i < 0 ? 0 : num1[i] - '0';
            //    n2 = j < 0 ? 0 : num2[j] - '0';

            //    sum = n1 + n2 + carry;
            //    sb.Append(sum % 10);

            //    carry = sum / 10;

            //    i--;
            //    j--;
            //}

            //return new string(sb.ToString().Reverse().ToArray());
        }
    }
}
