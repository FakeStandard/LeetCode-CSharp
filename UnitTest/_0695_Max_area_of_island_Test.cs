using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0695.Max_area_of_island;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0695.Max_area_of_island.Tests
{
    [TestClass()]
    public class _0695_Max_area_of_island_Test
    {
        _0695_Max_area_of_island solution = new _0695_Max_area_of_island();

        [TestMethod()]
        public void MaxAreaOfIsland_Test1()
        {
            // Arrange
            int[][] grid = new int[][]
            {
               new int[] { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
               new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
               new int[] { 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
               new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0 },
               new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
               new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
               new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
               new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 }
            };

            var expected = 6;

            // Act
            var actual = solution.MaxAreaOfIsland(grid);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxAreaOfIsland_Test2()
        {
            // Arrange
            int[][] grid = new int[][]
            {
               new int[] { 0, 0, 0, 0, 0, 0, 0, 0 },
            };

            var expected = 0;

            // Act
            var actual = solution.MaxAreaOfIsland(grid);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}