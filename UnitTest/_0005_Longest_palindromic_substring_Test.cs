using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0005.Longest_palindromic_substring;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0005.Longest_palindromic_substring.Tests
{
    [TestClass()]
    public class _0005_Longest_palindromic_substring_Test
    {
        _0005_Longest_palindromic_substring solution = new _0005_Longest_palindromic_substring();

        [TestMethod()]
        public void LongestPalindrome_Test1()
        {
            // Arrange
            string s = "babad";
            string expected = "bab";

            // Act
            var actual = solution.LongestPalindrome(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LongestPalindrome_Test2()
        {
            // Arrange
            string s = "cbbd";
            string expected = "bb";

            // Act
            var actual = solution.LongestPalindrome(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}