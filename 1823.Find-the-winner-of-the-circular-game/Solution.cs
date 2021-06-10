using System;
using System.Collections.Generic;

namespace _1823.Find_the_winner_of_the_circular_game
{
    public class Solution
    {
        public int FindTheWinner(int n, int k)
        {
            List<int> gamer = new List<int>();

            for (int i = 0; i < n; i++)
                gamer.Add(i + 1);

            int count = n;
            int index = 0;

            while (count > 1)
            {
                index = (index + k - 1) % gamer.Count;
                gamer.RemoveAt(index);
                count--;
            }

            return gamer[0];
        }
    }
}
