using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0056.Merge_intervals
{
    public class _0056_Merge_intervals
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals == null || intervals.Length == 0) return null;

            List<int[]> res = new List<int[]>();

            // first 1,2 end 1,2
            int f1, f2, e1, e2;

            for (int i = 0; i < intervals.Length; i++)
            {
                f1 = intervals[i][0];
                e1 = intervals[i][1];
                if (i == intervals.Length - 1)
                {
                    res.Add(new int[] { f1, e1 });
                    break;
                }

                f2 = intervals[i + 1][0];
                e2 = intervals[i + 1][1];

                if (f1 <= f2 && e2 >= e1 && f2 <= e1)
                {
                    // merge
                    res.Add(new int[] { f1, e2 });
                    i++;
                    continue;
                }
                else
                    res.Add(new int[] { f1, e1 });
            }

            return res.ToArray();
        }
    }
}
