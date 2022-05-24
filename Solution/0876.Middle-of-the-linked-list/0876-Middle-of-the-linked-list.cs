using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0876.Middle_of_the_linked_list
{
    public class _0876_Middle_of_the_linked_list
    {
        public ListNode MiddleNode(ListNode head)
        {
            List<ListNode> list = new List<ListNode>();

            while (head != null)
            {
                list.Add(head);
                head = head.next;
            }

            return list[list.Count / 2];
        }
    }
}
