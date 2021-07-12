using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0682.Baseball_game;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0682.Baseball_game.Tests
{
    [TestClass()]
    public class _0682_Baseball_game_Test
    {
        _0682_Baseball_game solution = new _0682_Baseball_game();

        [TestMethod()]
        public void CalPoints_Test1()
        {
            // Arrange
            string[] ops = new string[] { "5", "2", "C", "D", "+" };
            var expected = 30;

            // Act
            var actual = solution.CalPoints(ops);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalPoints_Test2()
        {
            // Arrange
            string[] ops = new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" };
            var expected = 27;

            // Act
            var actual = solution.CalPoints(ops);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalPoints_Test3()
        {
            // Arrange
            string[] ops = new string[] { "1" };
            var expected = 1;

            // Act
            var actual = solution.CalPoints(ops);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}