using Common;
using System;
using System.Text;

namespace _1290.Convert_binary_number_in_a_linked_list_to_integer
{
    public class Solution
    {
        public int GetDecimalValue(ListNode head)
        {
            int res = 0;

            while (head != null)
            {
                res <<= 1;
                res += head.val;
                head = head.next;
            }

            return res;

            #region Ohter Solution 1
            //int res = 0;

            //while (head != null)
            //{
            //    res = (res * 2) + head.val;
            //    head = head.next;
            //}

            //return res;
            #endregion

            #region Other Solution 2
            //StringBuilder sb = new StringBuilder();

            //while (head != null)
            //{
            //    sb.Append(head.val);
            //    head = head.next;
            //}

            //return Convert.ToInt32(sb.ToString(), 2);
            #endregion
        }
    }
}
