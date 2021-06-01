using System;

namespace _0147.Insertion_sort_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data;
            Solution s = new Solution();

            // ex1
            data = new int[] { 4, 2, 1, 3 };
            ListNode node = new ListNode(data[0]);
            ListNode first = node;

            for (int i = 1; i < data.Length; i++)
            {
                node.next = new ListNode(data[i]);
                node = node.next;
            }

            var result = s.InsertionSortList(first);

            while (result != null)
            {
                Console.Write($"[{result.val}] ");
                result = result.next;
            }

            // ex2
            data = new int[] { -1, 5, 3, 4, 0 };

            Console.ReadLine();
        }
    }

    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int val=0, ListNode next=null) {
     *         this.val = val;
     *         this.next = next;
     *     }
     * }
     */

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        public ListNode InsertionSortList(ListNode head)
        {
            head = new ListNode(-1) { next = head };

            return head;
        }
    }
}
