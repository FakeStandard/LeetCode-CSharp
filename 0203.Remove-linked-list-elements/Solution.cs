using Common;
using System;

namespace _0203.Remove_linked_list_elements
{
    public class Solution
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null) return head;

            ListNode current = head;
            ListNode pre = null;

            while (current != null)
            {
                if (current.val == val)
                {
                    if (head != current)
                        pre.next = current.next;
                    else
                        head = current.next;
                }
                else
                    pre = current;

                current = current.next;
            }

            return head;
        }
    }
}
