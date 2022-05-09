using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0141.Linked_list_cycle
{
    public class _0141_Linked_list_cycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null) return false;

            ListNode cur = head, pre = head;

            while (cur?.next != null)
            {
                pre = pre.next;
                cur = cur.next.next;

                if (cur == pre) return true;
            }

            return false;
        }
    }
}
