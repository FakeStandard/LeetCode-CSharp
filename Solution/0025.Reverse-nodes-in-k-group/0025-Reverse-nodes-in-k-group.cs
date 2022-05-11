using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0025.Reverse_nodes_in_k_group
{
    public class _0025_Reverse_nodes_in_k_group
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null || k <= 1) return head;

            Stack<int> stack = new Stack<int>();

            ListNode curr = head;
            ListNode node = new ListNode();
            ListNode res = node;

            while (curr != null)
            {
                stack.Push(curr.val);

                if (stack.Count == k)
                {
                    while (stack.Count > 0)
                    {
                        ListNode pop = new ListNode(stack.Pop());
                        node.next = pop;
                        node = node.next;
                    }
                }

                curr = curr.next;
            }

            if (stack.Count > 0)
            {
                Stack<int> s = new Stack<int>();

                // reverse stack
                while (stack.Count > 0)
                    s.Push(stack.Pop());

                // add tail
                while (s.Count > 0)
                {
                    node.next = new ListNode(s.Pop());
                    node = node.next;
                }
            }

            return res.next;
        }
    }
}
