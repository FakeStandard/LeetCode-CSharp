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
            private ListNode node;

            public MinStack()
            {
                node = null;
            }

            public void Push(int val)
            {
                ListNode curr = new ListNode() { val = val };

                if (node == null)
                    curr.minVal = val;
                else
                {
                    curr.minVal = Math.Min(node.minVal, val);
                    curr.next = node;
                }

                node = curr;
            }

            public void Pop()
            {
                node = node.next;
            }

            public int Top()
            {
                return node.val;
            }

            public int GetMin()
            {
                return node.minVal;
            }
        }

        public class ListNode
        {
            public int val;
            public int minVal;
            public ListNode next;
        }
    }
}
