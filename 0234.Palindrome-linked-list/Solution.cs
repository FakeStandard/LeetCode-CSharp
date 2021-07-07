using Common;
using System;
using System.Collections.Generic;

namespace _0234.Palindrome_linked_list
{
    public class Solution
    {
        public bool IsPalindrome(ListNode head)
        {
            Stack<int> stack = new Stack<int>();
            ListNode curr = head;

            while (curr != null)
            {
                stack.Push(curr.val);
                curr = curr.next;
            }

            while (head != null)
            {
                if (stack.Pop() != head.val)
                    return false;
                else
                    head = head.next;
            }

            return true;
        }
    }
}
