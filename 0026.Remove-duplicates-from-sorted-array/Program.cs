using System;

namespace _0026.Remove_duplicates_from_sorted_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            Console.WriteLine(s.RemoveDuplicates(new int[] { 1,1,2 }));

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int res = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[res] != nums[i])
                {
                    res++;
                    nums[res] = nums[i];
                }
            }

            res++;

            return res;

            //if (nums.Length == 0) return 0;

            //int res = 1;
            //bool b = false;

            //for(int i = 1; i < nums.Length; i++)
            //{
            //    b = false;

            //    for(int j = 0; j < res; j++)
            //    {
            //        if (nums[i] == nums[j])
            //        {
            //            b = true;
            //            break;
            //        }
            //    }

            //    if (!b)
            //    {
            //        nums[res] = nums[i];
            //        res++;
            //    }
            //}

            //return res;
        }
    }
}
