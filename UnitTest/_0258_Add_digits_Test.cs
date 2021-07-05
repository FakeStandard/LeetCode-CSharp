using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0258.Add_digits;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0258.Add_digits.Tests
{
    [TestClass()]
    public class _0258_Add_digits_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void AddDigits_Test1()
        {
            // Arrange
            int num = 38;
            var expected = 2;

            // Act
            var actual = solution.AddDigits(num);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddDigits_Test2()
        {
            // Arrange
            int num = 0;
            var expected = 0;

            // Act
            var actual = solution.AddDigits(num);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}