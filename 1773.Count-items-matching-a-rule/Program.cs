using System;
using System.Collections.Generic;

namespace _1773.Count_items_matching_a_rule
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int index = 0;
            int count = 0;

            if (ruleKey == "type") index = 0;
            else if (ruleKey == "color") index = 1;
            else if (ruleKey == "name") index = 2;

            foreach (var item in items)
            {
                if (item[index] == ruleValue)
                    count++;
            }

            return count;
        }
    }
}
