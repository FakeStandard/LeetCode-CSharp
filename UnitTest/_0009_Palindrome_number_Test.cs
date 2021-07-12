using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Solution._0009.Palindrome_number;

namespace _0009.Palindrome_number.Tests
{
    [TestClass()]
    public class _0009_Palindrome_number_Test
    {
        _0009_Palindrome_number solution = new _0009_Palindrome_number();

        [TestMethod()]
        public void IsPalindrome_Test1()
        {
            // Arrange
            int x = 121;

            // Act
            var actual = solution.IsPalindrome(x);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsPalindrome_Test2()
        {
            // Arrange
            int x = -121;

            // Act
            var actual = solution.IsPalindrome(x);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void IsPalindrome_Test3()
        {
            // Arrange
            int x = 10;

            // Act
            var actual = solution.IsPalindrome(x);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void IsPalindrome_Test4()
        {
            // Arrange
            int x = -101;

            // Act
            var actual = solution.IsPalindrome(x);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}