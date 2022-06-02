using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0082.Remove_duplicates_from_sorted_list_II
{
    public class _0082_Remove_duplicates_from_sorted_list_II
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return null;

            ListNode res = new ListNode();
            ListNode prev = res;
            res.next = head;

            while (head != null)
            {
                while (head.next != null && head.val == head.next.val)
                    head = head.next;
                if (prev.next == head)
                    prev = prev.next;
                else
                    prev.next = head.next;
                head = head.next;
            }

            return res.next;

            // easy
            //if (head == null) return head;

            //ListNode temp = new ListNode();
            //ListNode res = temp;
            //Dictionary<int, int> dic = new Dictionary<int, int>();

            //// because the head is sorted list.
            //while (head != null)
            //{
            //    if (!dic.TryAdd(head.val, 1))
            //        dic[head.val]++;

            //    head = head.next;
            //}

            //foreach (KeyValuePair<int, int> pair in dic)
            //{
            //    if (pair.Value == 1)
            //    {
            //        temp.next = new ListNode(pair.Key);
            //        temp = temp.next;
            //    }
            //}

            //return res.next;
        }
    }
}
