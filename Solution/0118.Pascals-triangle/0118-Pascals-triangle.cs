using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0118.Pascals_triangle
{
    public class _0118_Pascals_triangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> res = new List<IList<int>> { new List<int>() { 1 } };

            if (numRows == 1) return res;

            // 從第二層開始
            for (int i = 2; i <= numRows; i++)
            {
                // 初始第一個1
                List<int> tmp = new List<int>() { 1 };
                // i=3
                for (int j = 1; j < i - 1; j++)
                    tmp.Add(res[i - 2][j] + res[i - 2][j - 1]);

                // 添加最後一個1
                tmp.Add(1);

                // 添加到res物件
                res.Add(tmp);
            }

            // Solution 2
            //for (int i = 2; i <= numRows; i++)
            //{
            //    int[] tmp = new int[i];
            //    tmp[0] = 1;

            //    for (int j = 1; j < i - 1; j++)
            //        tmp[j] = res[i - 2][j] + res[i - 2][j - 1];

            //    tmp[i - 1] = 1;
            //    res.Add(tmp);
            //}

            return res;
        }
    }
}
