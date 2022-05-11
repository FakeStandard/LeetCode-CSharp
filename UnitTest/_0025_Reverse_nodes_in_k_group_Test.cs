using Common;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0025.Reverse_nodes_in_k_group;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0025.Reverse_nodes_in_k_group.Tests
{
    [TestClass()]
    public class _0025_Reverse_nodes_in_k_group_Test
    {
        _0025_Reverse_nodes_in_k_group solution = new _0025_Reverse_nodes_in_k_group();

        [TestMethod()]
        public void ReverseKGroup_Test1()
        {
            // Arrange
            ListNode head = new ListNode().AddNode(new int[] { 1, 2, 3, 4, 5 });
            int k = 2;
            var expected = new ListNode().AddNode(new int[] { 2, 1, 4, 3, 5 });

            // Act
            var actual = solution.ReverseKGroup(head, k);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void ReverseKGroup_Test2()
        {
            // Arrange
            ListNode head = new ListNode().AddNode(new int[] { 1, 2, 3, 4, 5 });
            int k = 3;
            var expected = new ListNode().AddNode(new int[] { 3, 2, 1, 4, 5 });

            // Act
            var actual = solution.ReverseKGroup(head, k);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void ReverseKGroup_Test3()
        {
            // Arrange
            ListNode head = new ListNode().AddNode(new int[] { 1, 2, 3, 4, 5 });
            int k = 1;
            var expected = new ListNode().AddNode(new int[] { 1, 2, 3, 4, 5 });

            // Act
            var actual = solution.ReverseKGroup(head, k);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void ReverseKGroup_Test4()
        {
            // Arrange
            ListNode head = new ListNode().AddNode(new int[] { 1, 2 });
            int k = 2;
            var expected = new ListNode().AddNode(new int[] { 2, 1 });

            // Act
            var actual = solution.ReverseKGroup(head, k);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}