using System;
using System.Linq;

namespace _1636.Sort_array_by_increasing_frequency
{
    public class Solution
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
