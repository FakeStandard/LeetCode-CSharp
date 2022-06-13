using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1207.Unique_number_of_occurrences;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1207.Unique_number_of_occurrences.Tests
{
    [TestClass()]
    public class _1207_Unique_number_of_occurrences_Test
    {
        _1207_Unique_number_of_occurrences solution = new _1207_Unique_number_of_occurrences();

        [TestMethod()]
        public void UniqueOccurrences_Test1()
        {
            // Arrange
            int[] arr = new int[] { 1, 2, 2, 1, 1, 3 };

            // Act
            var actual = solution.UniqueOccurrences(arr);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void UniqueOccurrences_Test2()
        {
            // Arrange
            int[] arr = new int[] { 1, 2 };

            // Act
            var actual = solution.UniqueOccurrences(arr);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void UniqueOccurrences_Test3()
        {
            // Arrange
            int[] arr = new int[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 };

            // Act
            var actual = solution.UniqueOccurrences(arr);

            // Assert
            Assert.IsTrue(actual);
        }
    }
}