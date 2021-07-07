using System;
using System.Collections.Generic;

namespace _0232.Implement_queue_using_stacks
{
    /**
     * Your MyQueue object will be instantiated and called as such:
     * MyQueue obj = new MyQueue();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Peek();
     * bool param_4 = obj.Empty();
     */
    public class MyQueue
    {
        /** Initialize your data structure here. */

        Stack<int> stack;
        Stack<int> newStack;

        public MyQueue()
        {
            stack = new Stack<int>();
            newStack = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            stack.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            if (newStack.Count == 0)
                while (stack.Count > 0)
                    newStack.Push(stack.Pop());

            return newStack.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            if (newStack.Count == 0)
                while (stack.Count > 0)
                    newStack.Push(stack.Pop());

            return newStack.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return (stack.Count == 0) && (newStack.Count == 0);
        }
    }
}
