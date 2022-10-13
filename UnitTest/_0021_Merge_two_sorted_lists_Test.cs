using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0021.Merge_two_sorted_lists;
using Common;
using FluentAssertions;

namespace _0021.Merge_two_sorted_lists.Tests
{
    [TestClass()]
    public class _0021_Merge_two_sorted_lists_Test
    {
        _0021_Merge_two_sorted_lists solution = new _0021_Merge_two_sorted_lists();

        [TestMethod()]
        public void MergeTwoLists_Test1()
        {
            // Arrange
            var l1 = new ListNode().AddNode(new int[] { 1, 2, 4 });
            var l2 = new ListNode().AddNode(new int[] { 1, 3, 4 });
            var expected = new ListNode().AddNode(new int[] { 1, 1, 2, 3, 4, 4 }); ;

            // Act
            var actual = solution.MergeTwoLists(l1, l2);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void MergeTwoLists_Test2()
        {
            // Arrange
            ListNode l1 = null;
            ListNode l2 = null;
            ListNode expected = null;

            // Act
            var actual = solution.MergeTwoLists(l1, l2);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void MergeTwoLists_Test3()
        {
            // Arrange
            ListNode l1 = null;
            ListNode l2 = new ListNode().AddNode(new int[] { 0 });
            ListNode expected = new ListNode().AddNode(new int[] { 0 });

            // Act
            var actual = solution.MergeTwoLists(l1, l2);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}