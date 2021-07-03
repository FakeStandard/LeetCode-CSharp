using System;
using System.Collections.Generic;

namespace _0118.Pascal_s_triangle
{
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            List<List<int>> res = new List<List<int>>();

            res.Add(new List<int>() { 1 });
            res.Add(new List<int>() { 1, 1 });

            for (int i = 2; i <= numRows; i++)
            {
                List<int> list = new List<int>();
                list.Add(1);

                for (int j = 1; j < i - 1; j++)
                    list.Add(res[i - 2][j - 1] + res[i - 2][j]);

                list.Add(1);
                res.Add(list);
            }

            return res.ToArray();
        }
    }
}
