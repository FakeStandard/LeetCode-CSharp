using Common;
using System;
using System.Collections.Generic;

namespace _0206.Reverse_linked_list
{
    public class Solution
    {
        /// <summary>
        /// Recursively Solution
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode node = ReverseList(head.next);
            head.next.next = head;
            head.next = null;

            return node;
        }

        /// <summary>
        /// Iteratively Solution
        /// faster than the previous solution.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        //public ListNode ReverseList(ListNode head)
        //{
        //    if (head == null) return head;

        //    ListNode prev = null;

        //    // 1->2->3->4->5
        //    while (head != null)
        //    {
        //        ListNode next = head.next;
        //        head.next = prev;
        //        prev = head;
        //        head = next;

        //        /* first time
        //         * next = 2->3->4->5
        //         * head.next = null
        //         * prev = 1
        //         * head = 2->3->4->5
        //         */
        //        /* second time
        //         * next = 3->4->5
        //         * head.next = 1
        //         * prev = 2->1
        //         * head = 3->4->5
        //         */
        //        /* next time
        //         * next = 4->5
        //         * head.next = 2->1
        //         * prev = 3->2->1
        //         * head = 4->5
        //         */
        //        /* next time
        //         * next = 5
        //         * head.next = 3->2->1
        //         * prev = 4->3->2->1
        //         * head = 5
        //         */
        //        /* the last time
        //         * next = null
        //         * head.next = 4->3->2->1
        //         * prev = 5->4->3->2->1
        //         * head = null
        //         */
        //    }

        //    return prev;
        //}

        /// <summary>
        /// Stack Solution
        /// the fastest solution, although not very smart.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        //public ListNode ReverseList(ListNode head)
        //{
        //    if (head == null) return head;

        //    ListNode res = new ListNode();
        //    ListNode cur = res;

        //    Stack<int> stack = new Stack<int>();

        //    while (head != null)
        //    {
        //        stack.Push(head.val);
        //        head = head.next;
        //    }

        //    while (stack.Count > 0)
        //    {
        //        ListNode node = new ListNode(stack.Pop());
        //        cur.next = node;
        //        cur = cur.next;
        //    }

        //    return res.next;
        //}
    }
}
