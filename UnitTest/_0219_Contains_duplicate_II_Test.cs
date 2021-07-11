using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0219.Contains_duplicate_II;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0219.Contains_duplicate_II.Tests
{
    [TestClass()]
    public class _0219_Contains_duplicate_II_Test
    {
        _0219_Contains_duplicate_II solution = new _0219_Contains_duplicate_II();

        [TestMethod()]
        public void ContainsNearbyDuplicate_Test1()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 1 };
            int k = 3;

            // Act
            var actual = solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void ContainsNearbyDuplicate_Test2()
        {
            // Arrange
            int[] nums = { 1, 0, 1, 1 };
            int k = 1;

            // Act
            var actual = solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void ContainsNearbyDuplicate_Test3()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 1, 2, 3 };
            int k = 2;

            // Act
            var actual = solution.ContainsNearbyDuplicate(nums, k);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}