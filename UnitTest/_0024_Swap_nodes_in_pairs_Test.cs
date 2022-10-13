using Common;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0024.Swap_nodes_in_pairs;

namespace _0024.Swap_nodes_in_pairs.Tests
{
    [TestClass()]
    public class _0024_Swap_nodes_in_pairs_Test
    {
        _0024_Swap_nodes_in_pairs solution = new _0024_Swap_nodes_in_pairs();

        [TestMethod()]
        public void SwapPairs_Test1()
        {
            // Arrange
            ListNode head = new ListNode().AddNode(new int[] { 1, 2, 3, 4 });
            var expected = new ListNode().AddNode(new int[] { 2, 1, 4, 3 });

            // Act
            var actual = solution.SwapPairs(head);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void SwapPairs_Test2()
        {
            // Arrange
            ListNode head = new ListNode().AddNode(new int[] { });
            var expected = new ListNode().AddNode(new int[] { });

            // Act
            var actual = solution.SwapPairs(head);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void SwapPairs_Test3()
        {
            // Arrange
            ListNode head = new ListNode().AddNode(new int[] { 1 });
            var expected = new ListNode().AddNode(new int[] { 1 });

            // Act
            var actual = solution.SwapPairs(head);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}