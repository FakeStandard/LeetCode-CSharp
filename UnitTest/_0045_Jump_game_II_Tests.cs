using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0045.Jump_game_II;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0045.Jump_game_II.Tests
{
    [TestClass()]
    public class _0045_Jump_game_II_Tests
    {
        _0045_Jump_game_II solution = new _0045_Jump_game_II();

        [TestMethod()]
        public void Jump_Test1()
        {
            // Arrange
            int[] nums = { 2, 3, 1, 1, 4 };
            var expected = 2;

            // Act
            var actual = solution.Jump(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Jump_Test2()
        {
            // Arrange
            int[] nums = { 2, 3, 0, 1, 4 };
            var expected = 2;

            // Act
            var actual = solution.Jump(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}