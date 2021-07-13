using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1486.XOR_Operation_in_an_array;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1486.XOR_Operation_in_an_array.Tests
{
    [TestClass()]
    public class _1486_XOR_Operation_in_an_array_Test
    {
        _1486_XOR_Operation_in_an_array solution = new _1486_XOR_Operation_in_an_array();

        [TestMethod()]
        public void XorOperation_Test1()
        {
            // Arrange
            int n = 5;
            int start = 0;
            var expected = 8;

            // Act
            var actual = solution.XorOperation(n, start);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void XorOperation_Test2()
        {
            // Arrange
            int n = 4;
            int start = 3;
            var expected = 8;

            // Act
            var actual = solution.XorOperation(n, start);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void XorOperation_Test3()
        {
            // Arrange
            int n = 1;
            int start = 7;
            var expected = 7;

            // Act
            var actual = solution.XorOperation(n, start);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void XorOperation_Test4()
        {
            // Arrange
            int n = 10;
            int start = 5;
            var expected = 2;

            // Act
            var actual = solution.XorOperation(n, start);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}