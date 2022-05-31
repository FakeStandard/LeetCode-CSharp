using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0215.Kth_largest_element_in_an_array;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0215.Kth_largest_element_in_an_array.Tests
{
    [TestClass()]
    public class _0215_Kth_largest_element_in_an_array_Test
    {
        _0215_Kth_largest_element_in_an_array solution = new _0215_Kth_largest_element_in_an_array();

        [TestMethod()]
        public void FindKthLargest_Test1()
        {
            // Arrange
            int[] nums = new int[] { 3, 2, 1, 5, 6, 4 };
            int k = 2;
            var expected = 5;

            // Act
            var actual = solution.FindKthLargest(nums, k);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindKthLargest_Test2()
        {
            // Arrange
            int[] nums = new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            int k = 4;
            var expected = 4;

            // Act
            var actual = solution.FindKthLargest(nums, k);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}