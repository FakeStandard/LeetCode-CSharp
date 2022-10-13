using Common;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0082.Remove_duplicates_from_sorted_list_II;

namespace _0082.Remove_duplicates_from_sorted_list_II.Tests
{
    [TestClass()]
    public class _0082_Remove_duplicates_from_sorted_list_II_Test
    {
        _0082_Remove_duplicates_from_sorted_list_II solution = new _0082_Remove_duplicates_from_sorted_list_II();

        [TestMethod()]
        public void DeleteDuplicates_Test1()
        {
            // Arrange
            ListNode head = new ListNode().AddNode(new int[] { 1, 2, 3, 3, 4, 4, 5 });
            var expected = new ListNode().AddNode(new int[] { 1, 2, 5 });

            // Act
            var actual = solution.DeleteDuplicates(head);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void DeleteDuplicates_Test2()
        {
            // Arrange
            ListNode head = new ListNode().AddNode(new int[] { 1, 1, 1, 2, 3 });
            var expected = new ListNode().AddNode(new int[] { 2, 3 });

            // Act
            var actual = solution.DeleteDuplicates(head);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}