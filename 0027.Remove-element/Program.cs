using System;

namespace _0027.Remove_element
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int res = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[res] = nums[i];
                    res++;
                }
            }

            return res;
        }
    }
}
