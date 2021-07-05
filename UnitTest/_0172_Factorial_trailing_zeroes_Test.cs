﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0172.Factorial_trailing_zeroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0172.Factorial_trailing_zeroes.Tests
{
    [TestClass()]
    public class _0172_Factorial_trailing_zeroes_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void TrailingZeroes_Test1()
        {
            // Arrange
            int n = 3;
            var expected = 0;

            // Act
            var actual = solution.TrailingZeroes(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TrailingZeroes_Test2()
        {
            // Arrange
            int n = 5;
            var expected = 1;

            // Act
            var actual = solution.TrailingZeroes(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TrailingZeroes_Test3()
        {
            // Arrange
            int n = 0;
            var expected = 0;

            // Act
            var actual = solution.TrailingZeroes(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}