using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0136.Single_number;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0136.Single_number.Tests
{
    [TestClass()]
    public class _0136_Single_number_Test
    {
        _0136_Single_number solution = new _0136_Single_number();

        [TestMethod()]
        public void SingleNumber_Test1()
        {
            // Arrange
            int[] nums = { 2, 2, 1 };
            var expected = 1;

            // Act
            var actual = solution.SingleNumber(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SingleNumber_Test2()
        {
            // Arrange
            int[] nums = { 4, 1, 2, 1, 2 };
            var expected = 4;

            // Act
            var actual = solution.SingleNumber(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SingleNumber_Test3()
        {
            // Arrange
            int[] nums = { 1 };
            var expected = 1;

            // Act
            var actual = solution.SingleNumber(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}