using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0994.Rotting_oranges;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0994.Rotting_oranges.Tests
{
    [TestClass()]
    public class _0994_Rotting_oranges_Test
    {
        _0994_Rotting_oranges solution = new _0994_Rotting_oranges();

        [TestMethod()]
        public void OrangesRotting_Test1()
        {
            // Arrange
            int[][] grid = new int[][]
            {
                new int[] { 2, 1, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 0, 1, 1 },
            };
            var expected = 4;

            // Act
            var actual = solution.OrangesRotting(grid);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void OrangesRotting_Test2()
        {
            // Arrange
            int[][] grid = new int[][]
            {
                new int[] { 2, 1, 1 },
                new int[] { 0, 1, 1 },
                new int[] { 1, 0, 1 },
            };
            var expected = -1;

            // Act
            var actual = solution.OrangesRotting(grid);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}