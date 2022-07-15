using System;
using System.Collections;
using System.Collections.Generic;

namespace Solution._0013.Roman_to_integer
{
    public class _0013_Roman_to_integer
    {
        public int RomanToInt(string s)
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

            // 儲存第一個字
            int counter = (int)dic[s[0]];

            for (int i = 1; i < s.Length; i++)
            {
                // 做加法原則
                if ((int)dic[s[i - 1]] >= (int)dic[s[i]])
                {
                    // 正常情況, keep going
                    counter += (int)dic[s[i]];
                }
                else // 否則做減法原則
                {
                    // 兩數組合, 依照羅馬數字規則做相減, 如 IV 為 5-1=4

                    // 先減去剛剛加的
                    //counter -= (int)dic[s[i - 1]];

                    // 再將兩數相減後再加回去
                    //counter += (int)dic[s[i]] - (int)dic[s[i - 1]];

                    counter += (int)dic[s[i]] - (int)dic[s[i - 1]] * 2;
                }
            }

            return counter;
        }
    }
}
