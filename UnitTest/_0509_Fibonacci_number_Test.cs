﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0509.Fibonacci_number;

namespace _0509.Fibonacci_number.Tests
{
    [TestClass()]
    public class _0509_Fibonacci_number_Test
    {
        _0509_Fibonacci_number solution = new _0509_Fibonacci_number();

        [TestMethod()]
        public void Fib_Test1()
        {
            // Arrange
            int n = 2;
            var expected = 1;

            // Act
            var actual = solution.Fib(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Fib_Test2()
        {
            // Arrange
            int n = 3;
            var expected = 2;

            // Act
            var actual = solution.Fib(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Fib_Test3()
        {
            // Arrange
            int n = 4;
            var expected = 3;

            // Act
            var actual = solution.Fib(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}