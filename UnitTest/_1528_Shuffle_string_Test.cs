using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1528.Shuffle_string;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1528.Shuffle_string.Tests
{
    [TestClass()]
    public class _1528_Shuffle_string_Test
    {
        _1528_Shuffle_string solution = new _1528_Shuffle_string();

        [TestMethod()]
        public void RestoreString_Test1()
        {
            // Arrange
            string s = "codeleet";
            int[] indices = { 4, 5, 6, 7, 0, 2, 1, 3 };
            var expected = "leetcode";

            // Act
            var actual = solution.RestoreString(s, indices);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RestoreString_Test2()
        {
            // Arrange
            string s = "abc";
            int[] indices = { 0, 1, 2 };
            var expected = "abc";

            // Act
            var actual = solution.RestoreString(s, indices);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RestoreString_Test3()
        {
            // Arrange
            string s = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            var expected = "nihao";

            // Act
            var actual = solution.RestoreString(s, indices);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RestoreString_Test4()
        {
            // Arrange
            string s = "aaiougrt";
            int[] indices = { 4, 0, 2, 6, 7, 3, 1, 5 };
            var expected = "arigatou";

            // Act
            var actual = solution.RestoreString(s, indices);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RestoreString_Test5()
        {
            // Arrange
            string s = "art";
            int[] indices = { 1, 0, 2 };
            var expected = "rat";

            // Act
            var actual = solution.RestoreString(s, indices);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}