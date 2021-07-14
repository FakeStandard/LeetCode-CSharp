using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solution._1636.Sort_array_by_increasing_frequency
{
    public class _1636_Sort_array_by_increasing_frequency
    {
        public int[] FrequencySort(int[] nums)
        {
            return nums
                    .GroupBy(x => x)
                    .OrderBy(x => x.Count())
                    .ThenByDescending(x => x.Key)
                    .SelectMany(x => Enumerable.Repeat(x.Key, x.Count()))
                    .ToArray();
        }
    }
}
