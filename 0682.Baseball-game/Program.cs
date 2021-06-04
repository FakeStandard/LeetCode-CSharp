using System;
using System.Collections.Generic;
using System.Linq;

namespace _0682.Baseball_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string[] ops;

            // ex1
            ops = new string[] { "5", "2", "C", "D", "+" };
            // Output: 30
            Console.WriteLine(s.CalPoints(ops));

            // ex2
            ops = new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" };
            // Output: 27
            Console.WriteLine(s.CalPoints(ops));

            // ex3
            ops = new string[] { "1" };
            // Outputs: 1
            Console.WriteLine(s.CalPoints(ops));

            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int CalPoints(string[] ops)
        {
            if (ops.Length == 0) return 0;

            Stack<int> stack = new Stack<int>();

            foreach (string s in ops)
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

            //if (ops.Length == 0) return 0;

            //int[] nums = new int[ops.Length];
            //int index = 0;

            //// D :前一個兩倍 C: 刪除前一個 +: 前兩個相加
            //for (int i = 0; i < ops.Length; i++)
            //{
            //    if (ops[i] == "D")
            //        nums[index] = nums[index - 1] * 2;
            //    else if (ops[i] == "C")
            //    {
            //        index--;
            //        nums[index] = 0;
            //        continue;
            //    }
            //    else if (ops[i] == "+")
            //        nums[index] = nums[index - 1] + nums[index - 2];
            //    else
            //        nums[index] = int.Parse(ops[i]);

            //    index++;
            //}

            //return nums.Sum();
        }
    }
}
