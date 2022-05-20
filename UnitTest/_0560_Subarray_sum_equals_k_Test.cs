using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0560.Subarray_sum_equals_k;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0560.Subarray_sum_equals_k.Tests
{
    [TestClass()]
    public class _0560_Subarray_sum_equals_k_Test
    {
        _0560_Subarray_sum_equals_k solution = new _0560_Subarray_sum_equals_k();

        [TestMethod()]
        public void SubarraySum_Test1()
        {
            // Arrange
            int[] nums = new int[] { 1, 1, 1 };
            int k = 2;
            int expected = 2;

            // Act
            var actual = solution.SubarraySum(nums, k);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubarraySum_Test2()
        {
            // Arrange
            int[] nums = new int[] { 1, 2, 3 };
            int k = 3;
            int expected = 2;

            // Act
            var actual = solution.SubarraySum(nums, k);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubarraySum_Test3()
        {
            // Arrange
            int[] nums = new int[] { 1, 2, 1, 2, 1 };
            int k = 3;
            int expected = 4;

            // Act
            var actual = solution.SubarraySum(nums, k);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubarraySum_Test4()
        {
            // Arrange
            int[] nums = new int[] { 0, 0 };
            int k = 0;
            int expected = 3;

            // Act
            var actual = solution.SubarraySum(nums, k);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}