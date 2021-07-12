using Common;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0002.Add_two_numbers;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0002.Add_two_numbers.Tests
{
    [TestClass()]
    public class _0002_Add_two_numbers_Test
    {
        _0002_Add_two_numbers solution = new _0002_Add_two_numbers();

        [TestMethod()]
        public void AddTwoNumbers_Test1()
        {
            // Arrange
            ListNode l1 = new ListNode().AddNode(new int[] { 2, 4, 3 });
            ListNode l2 = new ListNode().AddNode(new int[] { 5, 6, 4 });
            ListNode expected = new ListNode().AddNode(new int[] { 7, 0, 8 });

            // Act
            var actual = solution.AddTwoNumbers(l1, l2);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void AddTwoNumbers_Test2()
        {
            // Arrange
            ListNode l1 = new ListNode().AddNode(new int[] { 0 });
            ListNode l2 = new ListNode().AddNode(new int[] { 0 });
            ListNode expected = new ListNode().AddNode(new int[] { 0 });

            // Act
            var actual = solution.AddTwoNumbers(l1, l2);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void AddTwoNumbers_Test3()
        {
            // Arrange
            ListNode l1 = new ListNode().AddNode(new int[] { 9, 9, 9, 9, 9, 9, 9 });
            ListNode l2 = new ListNode().AddNode(new int[] { 9, 9, 9, 9 });
            ListNode expected = new ListNode().AddNode(new int[] { 8, 9, 9, 9, 0, 0, 0, 1 });

            // Act
            var actual = solution.AddTwoNumbers(l1, l2);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}