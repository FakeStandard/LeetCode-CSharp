using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solution._0155.Min_stack
{
    public class _0155_Min_stack
    {
        /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(val);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */
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
    }
}
