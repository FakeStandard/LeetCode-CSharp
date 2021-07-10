using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0168.Excel_sheet_column_title
{
    public class _0168_Excel_sheet_column_title
    {
        public string ConvertToTitle(int columnNumber)
        {
            int temp = columnNumber;
            StringBuilder sb = new StringBuilder();

            while (temp != 0)
            {
                temp--;
                sb.Append((char)(temp % 26 + 65));
                temp /= 26;
            }

            var c = sb.ToString().ToCharArray();

            Array.Reverse(c);

            return new string(c);
        }
    }
}
