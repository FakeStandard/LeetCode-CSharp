using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1823.Find_the_winner_of_the_circular_game;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1823.Find_the_winner_of_the_circular_game.Tests
{
    [TestClass()]
    public class _1823_Find_the_winner_of_the_circular_game_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void FindTheWinner_Test1()
        {
            // Arrange
            int n = 5;
            int k = 2;
            var expected = 3;

            // Act
            var actual = solution.FindTheWinner(n, k);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindTheWinner_Test2()
        {
            // Arrange
            int n = 6;
            int k= 5;
            var expected = 1;

            // Act
            var actual = solution.FindTheWinner(n, k);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}