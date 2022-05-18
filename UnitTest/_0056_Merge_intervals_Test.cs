using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0056.Merge_intervals;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0056.Merge_intervals.Tests
{
    [TestClass()]
    public class _0056_Merge_intervals_Test
    {
        _0056_Merge_intervals solution = new _0056_Merge_intervals();

        [TestMethod()]
        public void Merge_Test1()
        {
            // Arrange
            int[][] intervals = new int[][]
            {
                new int[]{ 1, 3 },
                new int[]{ 2, 6 },
                new int[]{ 8, 10 },
                new int[]{ 15, 18 },
            };

            var expected = new int[][]
            {
                new int[]{ 1, 6 },
                new int[]{ 8, 10 },
                new int[]{ 15, 18 },
            };

            // Act
            var actual = solution.Merge(intervals);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void Merge_Test2()
        {
            // Arrange
            int[][] intervals = new int[][]
            {
                new int[]{ 1, 4 },
                new int[]{ 4, 5 },
            };

            var expected = new int[][]
            {
                new int[]{ 1, 5 },
            };

            // Act
            var actual = solution.Merge(intervals);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void Merge_Test3()
        {
            // Arrange
            int[][] intervals = new int[][]
            {
                new int[]{ 1, 4 },
                new int[]{ 1, 4 },
            };

            var expected = new int[][]
            {
                new int[]{ 1, 4 },
            };

            // Act
            var actual = solution.Merge(intervals);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void Merge_Test4()
        {
            // Arrange
            int[][] intervals = new int[][]
            {
                new int[]{ 1, 4 },
                new int[]{ 0, 4 },
            };

            var expected = new int[][]
            {
                new int[]{ 0, 4 },
            };

            // Act
            var actual = solution.Merge(intervals);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}