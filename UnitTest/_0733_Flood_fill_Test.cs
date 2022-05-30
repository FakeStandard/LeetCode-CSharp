using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0733.Flood_fill;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0733.Flood_fill.Tests
{
    [TestClass()]
    public class _0733_Flood_fill_Test
    {
        _0733_Flood_fill solution = new _0733_Flood_fill();

        [TestMethod()]
        public void FloodFill_Test1()
        {
            // Arrange
            int[][] image = new int[][]
            {
                new int[] { 1, 1, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 1, 0, 1 },
            };

            int sr = 1;
            int sc = 1;
            int newColor = 2;
            var expected = new int[][]
            {
                new int[] { 2, 2, 2 },
                new int[] { 2, 2, 0 },
                new int[] { 2, 0, 1 },
            };

            // Act
            var actual = solution.FloodFill(image, sr, sc, newColor);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void FloodFill_Test2()
        {
            // Arrange
            int[][] image = new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 0, 0 },
            };

            int sr = 0;
            int sc = 0;
            int newColor = 2;
            var expected = new int[][]
            {
                new int[] { 2, 2, 2 },
                new int[] { 2, 2, 2 },
            };

            // Act
            var actual = solution.FloodFill(image, sr, sc, newColor);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}