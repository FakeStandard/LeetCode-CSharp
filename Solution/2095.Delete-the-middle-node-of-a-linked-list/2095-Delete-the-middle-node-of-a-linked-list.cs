using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._2095.Delete_the_middle_node_of_a_linked_list
{
    public class _2095_Delete_the_middle_node_of_a_linked_list
    {
        public ListNode DeleteMiddle(ListNode head)
        {
            // two pointers
            if (head == null || head.next == null) return null;

            var fast = head.next.next;
            var slow = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            slow.next = slow.next.next;

            return head;

            // counting
            //if (head == null) return null;

            //var curr = head;
            //var res = head;

            //int index = -1;
            //while (curr != null)
            //{
            //    curr = curr.next;
            //    index++;
            //}

            //if (index == 0) return new ListNode().AddNode(new int[] { });

            //int mid = index % 2 == 0 ? index / 2 : index / 2 + 1;

            //int count = 0;
            //while (res != null)
            //{
            //    // 2==2
            //    if (count == mid - 1)
            //    {
            //        var temp = res.next.next;
            //        res.next = temp;
            //        break;
            //    }

            //    count++;
            //    res = res.next;
            //}

            //return head;
        }
    }
}
