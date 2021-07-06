using System;
using System.Collections.Generic;
using System.Linq;

namespace _0682.Baseball_game
{
    public class Solution
    {
        public int CalPoints(string[] ops)
        {
            if (ops.Length == 0) return 0;

            Stack<int> stack = new Stack<int>();

            foreach (var s in ops)
            {
                switch (s)
                {
                    case "D":
                        stack.Push(stack.Peek() * 2);
                        break;
                    case "C":
                        stack.Pop();
                        break;
                    case "+":
                        int x = stack.Pop();
                        int y = stack.Pop();
                        stack.Push(y);
                        stack.Push(x);
                        stack.Push(x + y);
                        break;
                    default:
                        stack.Push(int.Parse(s));
                        break;
                }
            }

            int sum = 0;

            while (stack.Count() > 0)
                sum += stack.Pop();

            return sum;

            // Or directly use Sum() of LINQ's extension method.
            // return stack.Sum();
        }
    }
}
