using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0024.Swap_nodes_in_pairs
{
    public class _0024_Swap_nodes_in_pairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null) return null;

            ListNode res = new ListNode();
            res.next = head;
            ListNode prev = res;

            while (prev.next != null && prev.next.next != null)
            {
                ListNode l1 = prev.next;
                ListNode l2 = prev.next.next;

                l1.next = l2.next;
                l2.next = l1;

                prev.next = l2;
                prev = l1;
            }

            return res.next;
        }
    }
}
