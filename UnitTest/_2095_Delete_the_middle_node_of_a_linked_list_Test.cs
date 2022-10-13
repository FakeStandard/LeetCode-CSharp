using Common;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._2095.Delete_the_middle_node_of_a_linked_list;

namespace _2095.Delete_the_middle_node_of_a_linked_list.Tests
{
    [TestClass()]
    public class _2095_Delete_the_middle_node_of_a_linked_list_Test
    {
        _2095_Delete_the_middle_node_of_a_linked_list solution = new _2095_Delete_the_middle_node_of_a_linked_list();

        [TestMethod()]
        public void DeleteMiddle_Test1()
        {
            // Arrange
            var head = new ListNode().AddNode(new int[] { 1, 3, 4, 7, 1, 2, 6 });
            var expected = new ListNode().AddNode(new int[] { 1, 3, 4, 1, 2, 6 });

            // Act
            var actual = solution.DeleteMiddle(head);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void DeleteMiddle_Test2()
        {
            // Arrange
            var head = new ListNode().AddNode(new int[] { 1, 2, 3, 4 });
            var expected = new ListNode().AddNode(new int[] { 1, 2, 4 });

            // Act
            var actual = solution.DeleteMiddle(head);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void DeleteMiddle_Test3()
        {
            // Arrange
            var head = new ListNode().AddNode(new int[] { 1 });
            ListNode expected = null;

            // Act
            var actual = solution.DeleteMiddle(head);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}