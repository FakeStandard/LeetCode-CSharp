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
            if (head != null)
            {
                var curr = head;

                while (curr != null && curr.next != null)
                {
                    if (curr.val == curr.next.val)
                        curr.next = curr.next.next;
                    else
                        curr = curr.next;
                }
            }

            return head;
        }
    }
}
