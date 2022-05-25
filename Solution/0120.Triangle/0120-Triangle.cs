using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0120.Triangle
{
    public class _0120_Triangle
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            int sum = triangle[0][0];
            int index = 0;

            for (int i = 1; i < triangle.Count; i++)
            {
                if (triangle[i][index] < triangle[i][index + 1])
                    sum += triangle[i][index];
                else
                {
                    sum += triangle[i][index + 1];
                    index++;
                }
            }

            return sum;
        }
    }
}
