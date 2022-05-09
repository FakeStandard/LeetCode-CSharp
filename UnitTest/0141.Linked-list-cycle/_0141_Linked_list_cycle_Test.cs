using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0141.Linked_list_cycle;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0141.Linked_list_cycle.Tests
{
    [TestClass()]
    public class _0141_Linked_list_cycle_Test
    {
        _0141_Linked_list_cycle solution = new _0141_Linked_list_cycle();

        [TestMethod()]
        public void HasCycle_Test1()
        {
            // Arrange
            ListNode head = new ListNode().AddNode(new int[] { 3, 2, 0, -4 });

            // Act
            var actual = solution.HasCycle(head);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void HasCycle_Test2()
        {
            // Arrange
            ListNode head = new ListNode().AddNode(new int[] { 1, 2 });

            // Act
            var actual = solution.HasCycle(head);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void HasCycle_Test3()
        {
            // Arrange
            ListNode head = new ListNode().AddNode(new int[] { 1 });

            // Act
            var actual = solution.HasCycle(head);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}