using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0002.Add_two_numbers
{
    public class _0002_Add_two_numbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            // Linked List
            ListNode res = new ListNode();
            ListNode curr = res;
            int num1 = 0;
            int num2 = 0;
            int carry = 0;

            while ((l1 != null || l2 != null))
            {
                if (l1 != null)
                {
                    num1 = l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    num2 = l2.val;
                    l2 = l2.next;
                }

                carry = carry + num1 + num2;
                num1 = 0;
                num2 = 0;

                if (carry > 9)
                {
                    curr.next = new ListNode(carry % 10);
                    carry /= 10;
                }
                else
                {
                    curr.next = new ListNode(carry);
                    carry = 0;
                }

                curr = curr.next;
            }

            if (carry != 0)
                curr.next = new ListNode(carry);

            return res.next;
        }
    }
}
