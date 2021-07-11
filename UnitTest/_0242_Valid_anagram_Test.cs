using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0242.Valid_anagram;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0242.Valid_anagram.Tests
{
    [TestClass()]
    public class _0242_Valid_anagram_Test
    {
        _0242_Valid_anagram solution = new _0242_Valid_anagram();

        [TestMethod()]
        public void IsAnagram_Test1()
        {
            // Arrange
            string s = "anagram";
            string t = "nagaram";

            // Act
            var actual = solution.IsAnagram(s, t);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsAnagram_Test2()
        {
            // Arrange
            string s = "rat";
            string t = "car";

            // Act
            var actual = solution.IsAnagram(s, t);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void IsAnagram_Test3()
        {
            // Arrange
            string s = "anaaram";
            string t = "naagram";

            // Act
            var actual = solution.IsAnagram(s, t);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}