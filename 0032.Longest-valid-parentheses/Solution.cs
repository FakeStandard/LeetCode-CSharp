using System;
using System.Collections.Generic;

namespace _0032.Longest_valid_parentheses
{
    public class Solution
    {
        public int LongestValidParentheses(string s)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(-1);
            int max = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    stack.Push(i);
                else
                {
                    stack.Pop();

                    if (stack.Count == 0)
                        stack.Push(i);

                    max = max < i - stack.Peek() ? i - stack.Peek() : max;
                }
            }

            return max;
        }
    }
}
