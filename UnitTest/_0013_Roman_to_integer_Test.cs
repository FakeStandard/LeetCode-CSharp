using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0013.Roman_to_integer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0013.Roman_to_integer.Tests
{
    [TestClass()]
    public class _0013_Roman_to_integer_Test
    {
        _0013_Roman_to_integer solution = new _0013_Roman_to_integer();

        [TestMethod()]
        public void RomanToInt_Test1()
        {
            // Arrange
            string s = "III";
            var expected = 3;

            // Act
            var actual = solution.RomanToInt(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RomanToInt_Test2()
        {
            // Arrange
            string s = "IV";
            var expected = 4;

            // Act
            var actual = solution.RomanToInt(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RomanToInt_Test3()
        {
            // Arrange
            string s = "IX";
            var expected = 9;

            // Act
            var actual = solution.RomanToInt(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RomanToInt_Test4()
        {
            // Arrange
            string s = "LVIII";
            var expected = 58;

            // Act
            var actual = solution.RomanToInt(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RomanToInt_Test5()
        {
            // Arrange
            string s = "MCMXCIV";
            var expected = 1994;

            // Act
            var actual = solution.RomanToInt(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}