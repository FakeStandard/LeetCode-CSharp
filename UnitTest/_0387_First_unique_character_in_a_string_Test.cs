using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0387.First_unique_character_in_a_string;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0387.First_unique_character_in_a_string.Tests
{
    [TestClass()]
    public class _0387_First_unique_character_in_a_string_Test
    {
        _0387_First_unique_character_in_a_string solution = new _0387_First_unique_character_in_a_string();

        [TestMethod()]
        public void FirstUniqChar_Test1()
        {
            // Arrange
            string s = "leetcode";
            var expected = 0;

            // Act
            var actual = solution.FirstUniqChar(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FirstUniqChar_Test2()
        {
            // Arrange
            string s = "loveleetcode";
            var expected = 2;

            // Act
            var actual = solution.FirstUniqChar(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FirstUniqChar_Test3()
        {
            // Arrange
            string s = "aabb";
            var expected = -1;

            // Act
            var actual = solution.FirstUniqChar(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}