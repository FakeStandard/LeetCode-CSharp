using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0142.Linked_list_cycle_II
{
    public class _0142_Linked_list_cycle_II
    {
        public ListNode DetectCycle(ListNode head)
        {
            HashSet<ListNode> set = new HashSet<ListNode>();

            while (head != null)
            {
                if (set.Contains(head))
                    return head;
                else
                    set.Add(head);

                head = head.next;
            }

            return null;
        }
    }
}
