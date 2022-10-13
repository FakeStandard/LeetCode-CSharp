using Common;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0019.Remove_nth_node_from_end_of_list;

namespace _0019.Remove_nth_node_from_end_of_list.Tests
{
    [TestClass()]
    public class _0019_Remove_nth_node_from_end_of_list_Test
    {
        _0019_Remove_nth_node_from_end_of_list solution = new _0019_Remove_nth_node_from_end_of_list();

        [TestMethod()]
        public void RemoveNthFromEnd_Test1()
        {
            // Arrange
            ListNode head = new ListNode().AddNode(new int[] { 1, 2, 3, 4, 5 });
            int n = 2;
            var expected = new ListNode().AddNode(new int[] { 1, 2, 3, 5 });

            // Act
            var actual = solution.RemoveNthFromEnd(head, n);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        //[TestMethod()]
        //public void RemoveNthFromEnd_Test2()
        //{
        //    // Arrange
        //    ListNode head = new ListNode().AddNode(new int[] { 1 });
        //    int n = 1;
        //    var expected = new ListNode().AddNode(new int[] { });

        //    // Act
        //    var actual = solution.RemoveNthFromEnd(head, n);

        //    // Assert
        //    actual.Should().BeEquivalentTo(expected);
        //}

        [TestMethod()]
        public void RemoveNthFromEnd_Test3()
        {
            // Arrange
            ListNode head = new ListNode().AddNode(new int[] { 1, 2 });
            int n = 1;
            var expected = new ListNode().AddNode(new int[] { 1 });

            // Act
            var actual = solution.RemoveNthFromEnd(head, n);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void RemoveNthFromEnd_Test4()
        {
            // Arrange
            ListNode head = new ListNode().AddNode(new int[] { 1, 2 });
            int n = 2;
            var expected = new ListNode().AddNode(new int[] { 2 });

            // Act
            var actual = solution.RemoveNthFromEnd(head, n);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}