using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0198.House_robber;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0198.House_robber.Tests
{
    [TestClass()]
    public class _0198_House_robbercs_Test
    {
        _0198_House_robbercs solution = new _0198_House_robbercs();

        [TestMethod()]
        public void Rob_Test1()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 1 };
            int expected = 4;

            // Act
            var actual = solution.Rob(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Rob_Test2()
        {
            // Arrange
            int[] nums = { 2, 7, 9, 3, 1 };
            int expected = 12;

            // Act
            var actual = solution.Rob(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Rob_Test3()
        {
            // Arrange
            int[] nums = { 2, 1, 1, 2 };
            int expected = 4;

            // Act
            var actual = solution.Rob(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}