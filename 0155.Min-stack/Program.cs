using System;
using System.Collections.Generic;
using System.Linq;

namespace _0155.Min_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MinStack s = new MinStack();

            s.Push(2);
            s.Push(0);
            s.Push(3);
            s.Push(0);
            s.GetMin();

            s.Pop();
            s.GetMin();

            s.Pop();
            s.GetMin();

            s.Pop();
            s.GetMin();

            Console.ReadLine();
        }
    }

    public class MinStack
    {
        /** initialize your data structure here. */
        private Stack<int> stack;

        public MinStack()
        {
            stack = new Stack<int>();
        }

        public void Push(int val)
        {
            stack.Push(val);
        }

        public void Pop()
        {
            stack.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return stack.Min();
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(val);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */
}
