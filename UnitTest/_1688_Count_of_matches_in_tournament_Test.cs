using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1688.Count_of_matches_in_tournament;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1688.Count_of_matches_in_tournament.Tests
{
    [TestClass()]
    public class _1688_Count_of_matches_in_tournament_Test
    {
        _1688_Count_of_matches_in_tournament solution = new _1688_Count_of_matches_in_tournament();

        [TestMethod()]
        public void NumberOfMatches_Test1()
        {
            // Arrange
            int n = 7;
            var expected = 6;

            // Act
            var actual = solution.NumberOfMatches(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NumberOfMatches_Test2()
        {
            // Arrange
            int n = 14;
            var expected = 13;

            // Act
            var actual = solution.NumberOfMatches(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}