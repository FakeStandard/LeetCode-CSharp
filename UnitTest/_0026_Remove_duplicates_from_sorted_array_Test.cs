using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0026.Remove_duplicates_from_sorted_array;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0026.Remove_duplicates_from_sorted_array.Tests
{
    [TestClass()]
    public class _0026_Remove_duplicates_from_sorted_array_Test
    {
        _0026_Remove_duplicates_from_sorted_array solution = new _0026_Remove_duplicates_from_sorted_array();

        [TestMethod()]
        public void RemoveDuplicates_Test1()
        {
            // Arrange
            int[] nums = { 1, 1, 2 };
            var expected = 2;

            // Act
            var actual = solution.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RemoveDuplicates_Test2()
        {
            // Arrange
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var expected = 5;

            // Act
            var actual = solution.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}