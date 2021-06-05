using System;

namespace _0771.Jewels_and_stones
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string jewels;
            string stones;

            // ex1
            jewels = "aA";
            stones = "aAAbbbb";

            // Output: 3
            Console.WriteLine(s.NumJewelsInStones(jewels, stones));

            // ex2
            jewels = "z";
            stones = "ZZ";

            // Output: 0
            Console.WriteLine(s.NumJewelsInStones(jewels, stones));

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            int count = 0;

            foreach (var s in stones)
                if (jewels.Contains(s))
                    count++;

            return count;

            //int count = 0;

            //foreach (var j in jewels)
            //    foreach (var s in stones)
            //        if (j == s) count++;

            //return count;
        }
    }
}
