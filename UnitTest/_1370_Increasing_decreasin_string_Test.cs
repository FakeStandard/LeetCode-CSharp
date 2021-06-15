using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1370.Increasing_decreasin_string;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1370.Increasing_decreasin_string.Tests
{
    [TestClass()]
    public class _1370_Increasing_decreasin_string_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void SortString_Test1()
        {
            // Arrange
            string s = "aaaabbbbcccc";
            var expected = "abccbaabccba";

            // Act
            var actual = solution.SortString(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SortString_Test2()
        {
            // Arrange
            string s = "rat";
            var expected = "art";

            // Act
            var actual = solution.SortString(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SortString_Test3()
        {
            // Arrange
            string s = "leetcode";
            var expected = "cdelotee";

            // Act
            var actual = solution.SortString(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SortString_Test4()
        {
            // Arrange
            string s = "ggggggg";
            var expected = "ggggggg";

            // Act
            var actual = solution.SortString(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SortString_Test5()
        {
            // Arrange
            string s = "spo";
            var expected = "ops";

            // Act
            var actual = solution.SortString(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}