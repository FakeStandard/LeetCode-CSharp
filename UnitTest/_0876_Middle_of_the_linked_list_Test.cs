using Common;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0876.Middle_of_the_linked_list;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0876.Middle_of_the_linked_list.Tests
{
    [TestClass()]
    public class _0876_Middle_of_the_linked_list_Test
    {
        _0876_Middle_of_the_linked_list solution = new _0876_Middle_of_the_linked_list();

        [TestMethod()]
        public void MiddleNode_Test1()
        {
            // Arrange
            ListNode head = new ListNode().AddNode(new int[] { 1, 2, 3, 4, 5 });
            var expected = new ListNode().AddNode(new int[] { 3, 4, 5 });

            // Act
            var actual = solution.MiddleNode(head);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void MiddleNode_Test2()
        {
            // Arrange
            ListNode head = new ListNode().AddNode(new int[] { 1, 2, 3, 4, 5, 6 });
            var expected = new ListNode().AddNode(new int[] { 4, 5, 6 });

            // Act
            var actual = solution.MiddleNode(head);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}