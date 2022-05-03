using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2248.Intersection_of_Multiple_Arrays
{
    public class _2248_Intersection_of_Multiple_Arrays
    {
        public IList<int> Intersection(int[][] nums)
        {
            // Array - no fast
            //if (nums == null || nums.Length == 0) return new List<int> { };

            //int[] res = nums[0];

            //for (int i = 1; i < nums.Length; i++)
            //    res = res.Intersect(nums[i]).ToArray();

            //Array.Sort(res);

            //return res;


            // HashSet - fast
            if (nums == null || nums.Length == 0) return new List<int> { };

            HashSet<int> hash = new HashSet<int>(nums[0]);

            for (int i = 1; i < nums.Length; i++)
                hash.IntersectWith(nums[i]);

            var res = hash.ToList();
            res.Sort();

            return res;
        }
    }
}
