using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0021.Merge_two_sorted_lists
{
    public class _0021_Merge_two_sorted_lists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null || l2 == null) return l1 ?? l2;

            ListNode res = new ListNode(), cur = res;

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    cur.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    cur.next = l2;
                    l2 = l2.next;
                }

                cur = cur.next;
            }

            cur.next = l1 ?? l2;

            return res.next;
        }
    }
}
