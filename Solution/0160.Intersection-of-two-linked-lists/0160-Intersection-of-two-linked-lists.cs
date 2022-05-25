using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0160.Intersection_of_two_linked_lists
{
    public class _0160_Intersection_of_two_linked_lists
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null) return null;

            ListNode a = headA;
            ListNode b = headB;

            while (a != b)
            {
                a = a == null ? headB : a.next;
                b = b == null ? headA : b.next;
            }

            return a;
        }
    }
}
