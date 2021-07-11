using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0204.Count_primes;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0204.Count_primes.Tests
{
    [TestClass()]
    public class _0204_Count_primes_Test
    {
        _0204_Count_primes solution = new _0204_Count_primes();

        [TestMethod()]
        public void CountPrimes_Test1()
        {
            // Arrange
            int n = 10;
            var expected = 4;

            // Act
            var actual = solution.CountPrimes(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountPrimes_Test2()
        {
            // Arrange
            int n = 0;
            var expected = 0;

            // Act
            var actual = solution.CountPrimes(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountPrimes_Test3()
        {
            // Arrange
            int n = 1;
            var expected = 0;

            // Act
            var actual = solution.CountPrimes(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountPrimes_Test4()
        {
            // Arrange
            int n = 2;
            var expected = 0;

            // Act
            var actual = solution.CountPrimes(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}