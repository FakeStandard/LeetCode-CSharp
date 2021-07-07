using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0206.Reverse_linked_list;
using System;
using System.Collections.Generic;
using System.Text;
using Common;
using FluentAssertions;

namespace _0206.Reverse_linked_list.Tests
{
    [TestClass()]
    public class _0206_Reverse_linked_list_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void ReverseList_Test1()
        {
            // Arrange
            ListNode head = AddNode(new int[] { 1, 2, 3, 4, 5 });
            var expected = AddNode(new int[] { 5, 4, 3, 2, 1 });

            // Act
            var actual = solution.ReverseList(head);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void ReverseList_Test2()
        {
            // Arrange
            ListNode head = AddNode(new int[] { 1, 2 });
            var expected = AddNode(new int[] { 2, 1 });

            // Act
            var actual = solution.ReverseList(head);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void ReverseList_Test3()
        {
            // Arrange
            ListNode head = AddNode(new int[] { });
            var expected = AddNode(new int[] { });

            // Act
            var actual = solution.ReverseList(head);

            // Assert
            actual.Should().BeEquivalentTo(expected);
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