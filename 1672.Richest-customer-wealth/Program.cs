using System;
using System.Linq;

namespace _1672.Richest_customer_wealth
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            int[][] accounts;

            // ex1
            accounts = new int[][]
            {
                new int[]{ 1, 2, 3 },
                new int[]{ 3, 2, 1 }
            };

            // Output: 6
            Console.WriteLine(s.MaximumWealth(accounts));

            // ex2
            accounts = new int[][]
            {
                new int[]{ 1, 5 },
                new int[]{ 7, 3 },
                new int[]{ 3, 5 }
            };

            // Output: 10
            Console.WriteLine(s.MaximumWealth(accounts));

            // ex3
            accounts = new int[][]
            {
                new int[]{2, 8, 7 },
                new int[]{ 7,1,3 },
                new int[]{ 1, 9, 5 }
            };

            // Output: 17
            Console.WriteLine(s.MaximumWealth(accounts));

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int MaximumWealth(int[][] accounts)
        {
            int i, j, sum;
            int max = 0;

            for (i = 0; i < accounts.GetLength(0); i++)
            {
                sum = 0;

                for (j = 0; j < accounts[i].Length; j++)
                    sum += accounts[i][j];

                if (sum >= max)
                    max = sum;
            }

            return max;

            //if (accounts.Length == 0) return 0;

            //int max = 0;

            //for(int i = 0; i < accounts.Length; i++)
            //{
            //    int sum = accounts[i].Sum();
            //    max = Math.Max(max, sum);
            //}

            //return max;
        }
    }
}
