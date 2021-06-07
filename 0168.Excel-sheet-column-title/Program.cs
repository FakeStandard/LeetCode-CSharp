using System;
using System.Text;

namespace _0168.Excel_sheet_column_title
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }

    public class Solution
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

            //int temp = n;
            //StringBuilder tempResult = new StringBuilder();
            //char[] result = null;

            //while (temp != 0)
            //{
            //    temp--;
            //    tempResult.Append((char)(temp % 26 + 65));
            //    temp /= 26;
            //}

            //result = tempResult.ToString().ToCharArray();
            //Array.Reverse(result);
            //return new string(result);
        }
    }
}
