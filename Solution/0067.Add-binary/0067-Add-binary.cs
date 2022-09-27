using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Solution._0067.Add_binary
{
    public class _0067_Add_binary
    {
        public string AddBinary(string a, string b)
        {
            // 將 a,b 補 0 直到相同長度
            int maxLen = a.Length > b.Length ? a.Length : b.Length;
            a = a.PadLeft(maxLen, '0');
            b = b.PadLeft(maxLen, '0');

            // true 表示進位, false 則無
            bool carry = false;
            StringBuilder sb = new StringBuilder();

            int add;

            maxLen--;

            // 依據各種狀況進行相加
            while (maxLen > -1)
            {
                add = a[maxLen] + b[maxLen];

                if (add == 98) // a+b=2
                {
                    if (carry)
                        sb.Insert(0, '1');
                    else
                    {
                        sb.Insert(0, '0');
                        carry = true;
                    }
                }
                else if (add == 97) // a+b=1
                {
                    if (carry)
                        sb.Insert(0, '0');
                    else
                        sb.Insert(0, '1');
                }
                else // a+b=0
                {
                    if (carry)
                    {
                        sb.Insert(0, '1');
                        carry = false;
                    }
                    else
                        sb.Insert(0, '0');
                }

                maxLen--;
            }

            if (carry) sb.Insert(0, '1');

            return sb.ToString();
        }
    }
}
