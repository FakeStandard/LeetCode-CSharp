using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0053.Maximum_subarray;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Tests
{
    [TestClass()]
    public class _0053_Maximum_subarray_Test
    {
        _0053_Maximum_subarray solution = new _0053_Maximum_subarray();

        [TestMethod()]
        public void MaxSubArray_Test1()
        {
            // Arrange
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var expected = 6;

            // Act
            var actual = solution.MaxSubArray(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxSubArray_Test2()
        {
            // Arrange
            int[] nums = { 1 };
            var expected = 1;

            // Act
            var actual = solution.MaxSubArray(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxSubArray_Test3()
        {
            // Arrange
            int[] nums = { 5, 4, -1, 7, 8 };
            var expected = 23;

            // Act
            var actual = solution.MaxSubArray(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}