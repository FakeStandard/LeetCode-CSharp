using System;
using System.Collections.Generic;

namespace _1431.Kids_with_the_greatest_number_of_candies
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            int[] candies;
            int extraCandies;
            IList<bool> res;

            // ex1
            candies = new int[] { 2, 3, 5, 1, 3 };
            extraCandies = 3;

            // Output:[true,true,true,false,true]
            res = s.KidsWithCandies(candies, extraCandies);

            foreach(bool r in res)
                Console.Write($"{r} ");
            Console.WriteLine();

            // ex2
            candies = new int[] { 4, 2, 1, 1, 2 };
            extraCandies = 1;

            // Output:[true,false,false,false,false]
            res = s.KidsWithCandies(candies, extraCandies);

            foreach (bool r in res)
                Console.Write($"{r} ");
            Console.WriteLine();

            // ex3
            candies = new int[] { 12, 1, 12 };
            extraCandies = 10;

            // Output:[true,false,true]
            res = s.KidsWithCandies(candies, extraCandies);

            foreach (bool r in res)
                Console.Write($"{r} ");

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            if (candies.Length == 0) return null;

            IList<bool> res = new List<bool>();
            int i;
            int max = 0;

            for (i = 0; i < candies.Length; i++)
            {
                if (max < candies[i])
                    max = candies[i];
            }

            for (i = 0; i < candies.Length; i++)
                res.Add(candies[i] + extraCandies >= max);

            return res;
        }
    }
}
