using System;
using System.Collections;
using System.Collections.Generic;

namespace _0013_RomanToInteger
{
    /// <summary>
    /// For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.
    /// Roman numerals are usually written largest to smallest from left to right.However, the numeral for four is not IIII. Instead, the number four is written as IV.Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX.There are six instances where subtraction is used:
    /// - I can be placed before V (5) and X(10) to make 4 and 9. 
    /// - X can be placed before L(50) and C(100) to make 40 and 90. 
    /// - C can be placed before D(500) and M(1000) to make 400 and 900.
    /// Given a roman numeral, convert it to an integer.
    /// </summary>
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
