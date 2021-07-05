using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0069.Sqrt_x;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0069.Sqrt_x.Tests
{
    [TestClass()]
    public class _0069_Sqrt_x_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void MySqrt_Test1()
        {
            // Arrange
            int x = 4;
            var expected = 2;

            // Act
            var actual = solution.MySqrt(x);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MySqrt_Test2()
        {
            // Arrange
            int x = 8;
            var expected = 2;

            // Act
            var actual = solution.MySqrt(x);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}