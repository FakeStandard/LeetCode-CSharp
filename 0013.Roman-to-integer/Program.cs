using System;
using System.Collections;
using System.Collections.Generic;

namespace _0013.Roman_to_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int r;

            // Ex1
            s = "III";
            r = RomanToInt(s);
            Console.WriteLine(r);

            // Ex2
            s = "IV";
            r = RomanToInt(s);
            Console.WriteLine(r);

            // Ex3
            s = "IX";
            r = RomanToInt(s);
            Console.WriteLine(r);

            // Ex4
            s = "LVIII";
            r = RomanToInt(s);
            Console.WriteLine(r);

            // Ex5
            s = "MCMXCIV";
            r = RomanToInt(s);
            Console.WriteLine(r);

            Console.ReadLine();
        }

        /// <summary>
        /// 將羅馬值轉換成十進位數值
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int RomanToInt(string s)
        {
            if (s == null || s == String.Empty)
                return 0;

            IDictionary dic = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            int counter = 0;

            for (int i = 0; i < s.Length; i++)
            {
                // 先處理第一個字
                if (i == 0)
                {
                    counter += (int)dic[s[i]];
                    continue;
                }

                // 接著處理後續的字
                if ((int)dic[s[i - 1]] >= (int)dic[s[i]])
                {
                    // 正常情況, keep going
                    counter += (int)dic[s[i]];
                }
                else
                {
                    // 兩數組合, 依照羅馬數字規則做相減, 如 IV 為 5-1=4

                    // 先減去剛剛加的
                    counter -= (int)dic[s[i - 1]];

                    // 再將兩數相減後再加回去
                    counter += (int)dic[s[i]] - (int)dic[s[i - 1]];

                }
            }

            return counter;
        }
    }
}
