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

            Array.Sort(intervals, (m, n) => m[0].CompareTo(n[0]));
            List<int[]> res = new List<int[]>();


            int start = intervals[0][0];
            int end = intervals[0][1];

            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] <= end)
                {
                    end = Math.Max(end, intervals[i][1]);
                    continue;
                }

                res.Add(new int[] { start, end });

                start = intervals[i][0];
                end = Math.Max(end, intervals[i][1]);
            }

            // last item
            res.Add(new int[] { start, end });

            return res.ToArray();
        }
    }
}
