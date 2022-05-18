using Common;
using System;

namespace _0147.Insertion_sort_list
{
    public class Solution
    {
        public ListNode InsertionSortList(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode curr = null, next = null, res = curr;

            while (head != null)
            {
                next = head.next;

                while (curr != null && curr.next.val < head.val)
                    curr = curr.next;

                head.next = curr.next;
                curr.next = head;

                head = next;
            }

            return res.next;
        }
    }
}
