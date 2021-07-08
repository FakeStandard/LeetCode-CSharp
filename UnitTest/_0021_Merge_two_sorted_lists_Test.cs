using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0021.Merge_two_sorted_lists;
using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace Solution._0021.Merge_two_sorted_lists.Tests
{
    [TestClass()]
    public class _0021_Merge_two_sorted_lists_Test
    {
        _0021_Merge_two_sorted_lists solution = new _0021_Merge_two_sorted_lists();

        [TestMethod()]
        public void MergeTwoLists_Test1()
        {
            // Arrange
            var l1 = AddNode(new int[] { 1, 2, 4 });
            var l2 = AddNode(new int[] { 1, 3, 4 });
            var expected = AddNode(new int[] { 1, 1, 2, 3, 4, 4 });

            // Act
            var actual = solution.MergeTwoLists(l1, l2);

            // Assert
            Assert.ReferenceEquals(expected, actual);
        }

        [TestMethod()]
        public void MergeTwoLists_Test2()
        {
            // Arrange
            var l1 = AddNode(new int[] { });
            var l2 = AddNode(new int[] { });
            var expected = AddNode(new int[] { });

            // Act
            var actual = solution.MergeTwoLists(l1, l2);

            // Assert
            Assert.ReferenceEquals(expected, actual);
        }

        [TestMethod()]
        public void MergeTwoLists_Test3()
        {
            // Arrange
            var l1 = AddNode(new int[] { });
            var l2 = AddNode(new int[] { 0 });
            var expected = AddNode(new int[] { 0 });

            // Act
            var actual = solution.MergeTwoLists(l1, l2);

            // Assert
            Assert.ReferenceEquals(expected, actual);
        }

        private ListNode AddNode(int[] arr)
        {
            if (arr.Length <= 0)
                return new ListNode();

            ListNode res = new ListNode(arr[0]);
            ListNode current = res;

            for (int i = 1; i < arr.Length; i++)
            {
                ListNode newNode = new ListNode(arr[i]);

                current.next = newNode;
                current = current.next;
            }

            return res;
        }
    }
}