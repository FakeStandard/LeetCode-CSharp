using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0083.Remove_duplicates_from_sorted_list;
using System;
using System.Collections.Generic;
using System.Text;
using Common;
using FluentAssertions;

namespace _0083.Remove_duplicates_from_sorted_list.Tests
{
    [TestClass()]
    public class _0083_Remove_duplicates_from_sorted_list_Test
    {
        _0083_Remove_duplicates_from_sorted_list solution = new _0083_Remove_duplicates_from_sorted_list();

        [TestMethod()]
        public void DeleteDuplicates_Test1()
        {
            // Arrange
            ListNode head = new ListNode();
            head = head.AddNode(new int[] { 1, 1, 2 });

            ListNode expected = new ListNode();
            expected = expected.AddNode(new int[] { 1, 2 });

            // Act
            var actual = solution.DeleteDuplicates(head);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void DeleteDuplicates_Test2()
        {
            // Arrange
            ListNode head = new ListNode();
            head = head.AddNode(new int[] { 1, 1, 2, 3, 3 });

            ListNode expected = new ListNode();
            expected = expected.AddNode(new int[] { 1, 2, 3 });

            // Act
            var actual = solution.DeleteDuplicates(head);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}