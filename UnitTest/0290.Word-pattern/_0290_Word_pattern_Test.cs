using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0290.Word_pattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0290.Word_pattern.Tests
{
    [TestClass()]
    public class _0290_Word_pattern_Test
    {
        _0290_Word_pattern solution = new _0290_Word_pattern();

        [TestMethod()]
        public void WordPattern_Test1()
        {
            // Arrange
            string pattern = "abba";
            string s = "dog cat cat dog";

            // Act
            var actual = solution.WordPattern(pattern, s);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void WordPattern_Test2()
        {
            // Arrange
            string pattern = "abba";
            string s = "dog cat cat fish";

            // Act
            var actual = solution.WordPattern(pattern, s);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void WordPattern_Test3()
        {
            // Arrange
            string pattern = "aaaa";
            string s = "dog cat cat dog";

            // Act
            var actual = solution.WordPattern(pattern, s);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void WordPattern_Test4()
        {
            // Arrange
            string pattern = "abba";
            string s = "dog dog dog dog";

            // Act
            var actual = solution.WordPattern(pattern, s);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void WordPattern_Test5()
        {
            // Arrange
            string pattern = "aaa";
            string s = "aa aa aa aa";

            // Act
            var actual = solution.WordPattern(pattern, s);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}