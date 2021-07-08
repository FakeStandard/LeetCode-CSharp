using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0007.Reverse_integer
{
    public class _0007_Reverse_integer
    {
        public int Reverse(int x)
        {
            try
            {
                // 拆解成字元
                char[] ch = x.ToString().ToCharArray();

                // 反轉陣列
                Array.Reverse(ch);

                string result = new string(ch);

                if (result.Contains("-"))
                    result = "-" + (result.Replace("-", ""));

                return int.Parse(result);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
