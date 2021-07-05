using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0203.Remove_linked_list_elements;
using System;
using System.Collections.Generic;
using System.Text;
using Common;
using FluentAssertions;

namespace _0203.Remove_linked_list_elements.Tests
{
    [TestClass()]
    public class _0203_Remove_Linked_List_Elements_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void RemoveElements_Test1()
        {
            // Arrange
            ListNode head = AddNode(new int[] { 1, 2, 6, 3, 4, 5, 6 });
            int val = 6;
            var expected = AddNode(new int[] { 1, 2, 3, 4, 5 });

            // Act
            var actual = solution.RemoveElements(head, val);

            // Assert
            //Assert.ReferenceEquals(expected, actual);

            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void RemoveElements_Test2()
        {
            // Arrange
            ListNode head = AddNode(new int[] { });
            int val = 1;
            var expected = AddNode(new int[] { });

            // Act
            var actual = solution.RemoveElements(head, val);

            // Assert
            //Assert.ReferenceEquals(expected, actual);

            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void RemoveElements_Test3()
        {
            // Arrange
            ListNode head = AddNode(new int[] { 7, 7, 7, 7 });
            int val = 7;
            ListNode expected = null;

            // Act
            var actual = solution.RemoveElements(head, val);

            // Assert
            //Assert.ReferenceEquals(expected, actual);

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