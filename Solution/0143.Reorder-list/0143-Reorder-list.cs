using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0143.Reorder_list
{
    public class _0143_Reorder_list
    {
        public void ReorderList(ListNode head)
        {
            if (head == null) return;

            var temp = head;
            Stack<ListNode> stack = new Stack<ListNode>();

            int count = 0;

            while (temp != null)
            {
                var node = new ListNode() { val = temp.val };
                stack.Push(node);
                temp = temp.next;

                count++;
            }

            var curr = head;
            int mid = count / 2;

            while (curr != null && stack.Count > mid)
            {
                var node = stack.Pop();
                node.next = curr.next;
                curr.next = node;

                if (stack.Count > mid)
                    curr = curr.next.next;
                else
                {
                    if (count % 2 == 0)
                        curr.next.next = null;
                    else
                        curr.next = null;
                }
            }
        }
    }
}
