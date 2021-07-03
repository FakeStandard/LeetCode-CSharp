using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0083.Remove_duplicates_from_sorted_list;
using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace _0083.Remove_duplicates_from_sorted_list.Tests
{
    [TestClass()]
    public class _0083_Remove_duplicates_from_sorted_list_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void DeleteDuplicates_Test1()
        {
            // Arrange
            ListNode head = AddNode(new int[] { 1, 1, 2 });
            ListNode expected = AddNode(new int[] { 1, 2 });

            // Act
            var actual = solution.DeleteDuplicates(head);

            // Assert
            Assert.ReferenceEquals(expected, actual);
        }

        [TestMethod()]
        public void DeleteDuplicates_Test2()
        {
            // Arrange
            ListNode head = AddNode(new int[] { 1, 1, 2, 3, 3 });
            ListNode expected = AddNode(new int[] { 1, 2, 3 });

            // Act
            var actual = solution.DeleteDuplicates(head);

            // Assert
            Assert.ReferenceEquals(expected, actual);
        }

        private ListNode AddNode(int[] arr)
        {
            if (arr.Length <= 0)
                return new ListNode();

            ListNode res = new ListNode(arr[0]);
            ListNode current = res;

            for (int i = 1; i < arr.Length; i++)
            {
                ListNode newNode = new ListNode(arr[i]);

                current.next = newNode;
                current = current.next;
            }

            return res;
        }
    }
}