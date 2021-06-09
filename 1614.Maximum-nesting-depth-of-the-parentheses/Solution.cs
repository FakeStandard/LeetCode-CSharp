using System;

namespace _1614.Maximum_nesting_depth_of_the_parentheses
{
    public class Solution
    {
        public int MaxDepth(string s)
        {
            int count = 0;
            int depth = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    count++;
                    if (count > depth)
                        depth = count;
                }
                else if (s[i] == ')')
                    count--;
            }

            return depth;
        }
    }
}
