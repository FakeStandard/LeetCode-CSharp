using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0019.Remove_nth_node_from_end_of_list
{
    public class _0019_Remove_nth_node_from_end_of_list
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null) return head;

            ListNode curr = head, tmp = curr, res = curr;
            int count = 0;

            // counting
            while (tmp != null)
            {
                count++;
                tmp = tmp.next;
            }

            if (count == 1 || count == n) return res.next;

            while (head != null)
            {
                if (count == n + 1)
                {
                    curr.next = head.next.next;
                    break;
                }

                count--;
                curr = head.next;
                head = head.next;
            }

            return res;
        }
    }
}
