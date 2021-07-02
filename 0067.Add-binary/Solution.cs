using System;
using System.Linq;
using System.Text;

namespace _0067.Add_binary
{
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            if (a == null || a == string.Empty || b == null || b == string.Empty)
                return a == null || a == string.Empty ? b : a;

            // true 表進位, false 表無進位
            bool carry = false;

            StringBuilder sb = new StringBuilder();

            int i;

            // 長度不同時補零到同長度
            if (a.Length > b.Length)
            {
                b = b.PadLeft(a.Length, '0');
                i = a.Length - 1;
            }
            else if (b.Length > a.Length)
            {
                a = a.PadLeft(b.Length, '0');
                i = b.Length - 1;
            }
            else
                i = a.Length - 1;

            // 依據各種情況進行相加
            while (i > -1)
            {
                if (a[i] == b[i] && a[i] == '0')
                {
                    if (!carry)
                        sb.Append("0");
                    else
                    {
                        sb.Append("1");
                        carry = false;
                    }
                }
                else if (a[i] == b[i] && a[i] == '1')
                {
                    if (!carry)
                    {
                        sb.Append("0");
                        carry = true;
                    }
                    else
                        sb.Append("1");
                }
                else if (a[i] == '1' || b[i] == '1')
                {
                    if (!carry)
                        sb.Append("1");
                    else
                        sb.Append("0");
                }

                i--;
            }

            if (carry)
                sb.Append("1");

            return new string(sb.ToString().Reverse().ToArray());
        }
    }
}
