using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1805.Number_of_different_integers_in_a_string;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1805.Number_of_different_integers_in_a_string.Tests
{
    [TestClass()]
    public class _1805_Number_of_different_integers_in_a_string_Test
    {
        _1805_Number_of_different_integers_in_a_string solution = new _1805_Number_of_different_integers_in_a_string();

        [TestMethod()]
        public void NumDifferentIntegers_Test1()
        {
            // Arrange
            string word = "a123bc34d8ef34";
            var expected = 3;

            // Act
            var actual = solution.NumDifferentIntegers(word);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NumDifferentIntegers_Test2()
        {
            // Arrange
            string word = "leet1234code234";
            var expected = 2;

            // Act
            var actual = solution.NumDifferentIntegers(word);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NumDifferentIntegers_Test3()
        {
            // Arrange
            string word = "a1b01c001";
            var expected = 1;

            // Act
            var actual = solution.NumDifferentIntegers(word);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NumDifferentIntegers_Test4()
        {
            // Arrange
            string word = "167278959591294";
            var expected = 1;

            // Act
            var actual = solution.NumDifferentIntegers(word);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}