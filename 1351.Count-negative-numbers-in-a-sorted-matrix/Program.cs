using System;

namespace _1351.Count_negative_numbers_in_a_sorted_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[][] grid;

            // ex1
            grid = new int[][]
            {
                new int[]{4, 3, 2, -1},
                new int[]{3,2,1,-1},
                new int[]{1,1,-1,-2},
                new int[]{-1,-1,-2,-3},
            };
            // Output: 8
            Console.WriteLine(s.CountNegatives(grid));

            // ex2
            grid = new int[][]
            {
                new int[]{3,2},
                new int[]{1,0}
            };
            // Output: 0
            Console.WriteLine(s.CountNegatives(grid));

            // ex3
            grid = new int[][]
            {
                new int[]{1, -1},
                new int[]{ -1, -1 }
            };
            // Output: 3
            Console.WriteLine(s.CountNegatives(grid));

            // ex4
            grid = new int[][]
            {
                new int[]{ -1}
            };
            // Output: 1
            Console.WriteLine(s.CountNegatives(grid));

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int CountNegatives(int[][] grid)
        {
            var count = 0;

            foreach(var arr in grid)
                foreach(var i in arr)
                    if (i < 0)
                        count++;

            return count;
        }
    }
}
