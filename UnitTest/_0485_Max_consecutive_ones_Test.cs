using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0485.Max_consecutive_ones;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0485.Max_consecutive_ones.Tests
{
    [TestClass()]
    public class _0485_Max_consecutive_ones_Test
    {
        _0485_Max_consecutive_ones solution = new _0485_Max_consecutive_ones();

        [TestMethod()]
        public void FindMaxConsecutiveOnes_Test1()
        {
            // Arrange
            int[] nums = new int[] { 1, 1, 0, 1, 1, 1 };
            int expected = 3;

            // Act
            var actual = solution.FindMaxConsecutiveOnes(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindMaxConsecutiveOnes_Test2()
        {
            // Arrange
            int[] nums = new int[] { 1, 0, 1, 1, 0, 1 };
            int expected = 2;

            // Act
            var actual = solution.FindMaxConsecutiveOnes(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}