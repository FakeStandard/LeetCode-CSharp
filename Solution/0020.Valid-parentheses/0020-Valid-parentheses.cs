using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0020.Valid_parentheses
{
    public class _0020_Valid_parentheses
    {
        public bool IsValid(string s)
        {
            if (s.Length % 2 != 0) return false;

            Stack<char> stack = new Stack<char>();

            // faster
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    stack.Push(')');
                else if (s[i] == '[')
                    stack.Push(']');
                else if (s[i] == '{')
                    stack.Push('}');
                else if (stack.Count == 0 || s[i] != stack.Pop())
                    return false;
            }

            //foreach (char c in s.ToCharArray())
            //{
            //    if (c == '(')
            //        stack.Push(')');
            //    else if (c == '[')
            //        stack.Push(']');
            //    else if (c == '{')
            //        stack.Push('}');
            //    else if (stack.Count == 0 || c != stack.Pop())
            //        return false;
            //}

            return stack.Count == 0;
        }
    }
}
