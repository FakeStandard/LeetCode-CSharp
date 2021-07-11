using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0237.Delete_node_in_a_linked_list
{
    public class _0237_Delete_node_in_a_linked_list
    {
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
