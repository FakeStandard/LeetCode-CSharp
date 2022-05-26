using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0451.Sort_characters_by_frequency;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0451.Sort_characters_by_frequency.Tests
{
    [TestClass()]
    public class _0451_Sort_characters_by_frequency_Test
    {
        _0451_Sort_characters_by_frequency solution = new _0451_Sort_characters_by_frequency();

        [TestMethod()]
        public void FrequencySort_Test1()
        {
            // Arrange
            string s = "tree";
            string expected = "eetr"; // eert is also correct.

            // Act
            var actual = solution.FrequencySort(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FrequencySort_Test2()
        {
            // Arrange
            string s = "cccaaa";
            string expected = "cccaaa"; // aaaccc is also correct.

            // Act
            var actual = solution.FrequencySort(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FrequencySort_Test3()
        {
            // Arrange
            string s = "Aabb";
            string expected = "bbAa";

            // Act
            var actual = solution.FrequencySort(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FrequencySort_Test4()
        {
            // Arrange
            string s = "raaeaedere";
            string expected = "eeeeaaarrd";

            // Act
            var actual = solution.FrequencySort(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}