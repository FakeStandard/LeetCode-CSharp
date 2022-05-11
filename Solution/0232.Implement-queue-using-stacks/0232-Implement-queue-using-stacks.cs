using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0232.Implement_queue_using_stacks
{
    public class _0232_Implement_queue_using_stacks
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

            Stack<int> curr;
            Stack<int> reverse;

            public MyQueue()
            {
                //  using only two stacks.
                curr = new Stack<int>();
                reverse = new Stack<int>();
            }

            /** Push element x to the back of queue. */
            public void Push(int x)
            {
                curr.Push(x);
            }

            /** Removes the element from in front of queue and returns that element. */
            public int Pop()
            {
                if (reverse.Count == 0)
                    while (curr.Count > 0)
                        reverse.Push(curr.Pop());

                return reverse.Pop();
            }

            /** Get the front element. */
            public int Peek()
            {
                if (reverse.Count == 0)
                    while (curr.Count > 0)
                        reverse.Push(curr.Pop());

                return reverse.Peek();
            }

            /** Returns whether the queue is empty. */
            public bool Empty()
            {
                return (curr.Count == 0) && (reverse.Count == 0);
            }
        }
    }
}
