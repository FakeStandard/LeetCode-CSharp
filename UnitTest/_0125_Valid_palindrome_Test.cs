using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0125.Valid_palindrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0125.Valid_palindrome.Tests
{
    [TestClass()]
    public class _0125_Valid_palindrome_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void IsPalindrome_Test1()
        {
            // Arrange
            string s = "A man, a plan, a canal: Panama";

            // Act
            var actual = solution.IsPalindrome(s);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsPalindrome_Test2()
        {
            // Arrange
            string s = "race a car";

            // Act
            var actual = solution.IsPalindrome(s);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}