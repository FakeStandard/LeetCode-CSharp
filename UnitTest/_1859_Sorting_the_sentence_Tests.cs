using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolutionLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionLib.Tests
{
    [TestClass()]
    public class _1859_Sorting_the_sentence_Tests
    {
        _1859_Sorting_the_sentence s = new _1859_Sorting_the_sentence();

        [TestMethod()]
        public void SortSentence_Test1()
        {
            // Arrange
            var expected = "This is a sentence";

            // Act
            var actual = s.SortSentence("is2 sentence4 This1 a3");

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SortSentence_Test2()
        {
            // Arrange
            var expected = "Me Myself and I";

            // Act
            var actual = s.SortSentence("Myself2 Me1 I4 and3");

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}