using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0083.Remove_duplicates_from_sorted_list
{
    public class _0083_Remove_duplicates_from_sorted_list
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head != null && head.next != null)
            {
                var current = head;

                while (current != null && current.next != null)
                {
                    if (current.val == current.next.val)
                        current.next = current.next.next;
                    else
                        current = current.next;
                }
            }

            return head;

            //if (head == null) return null;

            //ListNode current = new ListNode(head.val);
            //ListNode res = current;

            //while (head != null)
            //{
            //    if (head.val != current.val)
            //    {
            //        current.next = new ListNode(head.val);
            //        current = current.next;
            //    }

            //    head = head.next;
            //}

            //return res;
        }
    }
}
