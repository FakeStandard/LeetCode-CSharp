using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1249.Minimum_remove_to_make_valid_parentheses
{
    public class _1249_Minimum_remove_to_make_valid_parentheses
    {
        public string MinRemoveToMakeValid(string s)
        {
            if (s == null || s.Length == 0) return s;

            var stack = new Stack<Tuple<char, int>>();
            var arr = s.ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                if (stack.Count > 0 && arr[i] == ')' && stack.Peek().Item1 == '(')
                    stack.Pop();
                else if (arr[i] == '(' || arr[i] == ')')
                    stack.Push(new Tuple<char, int>(arr[i], i));
            }

            while (stack.Count > 0)
            {
                int i = stack.Peek().Item2;
                arr[i] = ' ';
                stack.Pop();
            }

            return new string(arr).Replace(" ", String.Empty);
        }
    }
}
