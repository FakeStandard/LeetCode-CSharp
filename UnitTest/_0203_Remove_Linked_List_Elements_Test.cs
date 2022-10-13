using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0203.Remove_linked_list_elements;
using Common;
using FluentAssertions;

namespace _0203.Remove_linked_list_elements.Tests
{
    [TestClass()]
    public class _0203_Remove_Linked_List_Elements_Test
    {
        _0203_Remove_linked_list_elements solution = new _0203_Remove_linked_list_elements();

        [TestMethod()]
        public void RemoveElements_Test1()
        {
            // Arrange
            ListNode head = new ListNode().AddNode(new int[] { 1, 2, 6, 3, 4, 5, 6 });
            int val = 6;
            var expected = new ListNode().AddNode(new int[] { 1, 2, 3, 4, 5 });

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
            ListNode head = new ListNode().AddNode(new int[] { });
            int val = 1;
            var expected = new ListNode().AddNode(new int[] { });

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
            ListNode head = new ListNode().AddNode(new int[] { 7, 7, 7, 7 });
            int val = 7;
            ListNode expected = null;

            // Act
            var actual = solution.RemoveElements(head, val);

            // Assert
            //Assert.ReferenceEquals(expected, actual);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}