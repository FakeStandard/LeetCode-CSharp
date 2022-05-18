using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0119.Pascals_triangle_II
{
    public class _0119_Pascals_triangle_II
    {
        public IList<int> GetRow(int rowIndex)
        {
            IList<IList<int>> res = new List<IList<int>>();
            res.Add(new List<int>() { 1 });

            if (rowIndex == 0) return res[0];

            // 從第二行開始
            for (int i = 1; i <= rowIndex; i++)
            {
                // 初始第一項
                List<int> curr = new List<int>() { 1 };

                for (int j = 1; j < i; j++)
                    curr.Add(res[i - 1][j - 1] + res[i - 1][j]);

                curr.Add(1);

                res.Add(curr);
            }

            return res[rowIndex];
        }
    }
}
