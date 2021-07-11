using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0203.Remove_linked_list_elements
{
    public class _0203_Remove_linked_list_elements
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
