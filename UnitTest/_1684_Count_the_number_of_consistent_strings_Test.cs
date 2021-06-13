using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1684.Count_the_number_of_consistent_strings;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1684.Count_the_number_of_consistent_strings.Tests
{
    [TestClass()]
    public class _1684_Count_the_number_of_consistent_strings_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void CountConsistentStrings_Test1()
        {
            // Arrange
            string allowed = "ab";
            string[] words = { "ad", "bd", "aaab", "baa", "badab" };
            var expected = 2;

            // Act
            var actual = solution.CountConsistentStrings(allowed, words);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountConsistentStrings_Test2()
        {
            // Arrange
            string allowed = "abc";
            string[] words = { "a", "b", "c", "ab", "ac", "bc", "abc" };
            var expected = 7;

            // Act
            var actual = solution.CountConsistentStrings(allowed, words);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountConsistentStrings_Test3()
        {
            // Arrange
            string allowed = "cad";
            string[] words = { "cc", "acd", "b", "ba", "bac", "bad", "ac", "d" };
            var expected = 4;

            // Act
            var actual = solution.CountConsistentStrings(allowed, words);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}