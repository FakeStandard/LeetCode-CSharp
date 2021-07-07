using Common;
using System;

namespace _0237.Delete_node_in_a_linked_list
{
    public class Solution
    {
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
