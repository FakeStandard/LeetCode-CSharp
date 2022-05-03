using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2248.Intersection_of_Multiple_Arrays;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2248.Intersection_of_Multiple_Arrays.Tests
{
    [TestClass()]
    public class _2248_Intersection_of_Multiple_Arrays_Test
    {
        _2248_Intersection_of_Multiple_Arrays solution = new _2248_Intersection_of_Multiple_Arrays();

        [TestMethod()]
        public void Intersection_Test1()
        {
            // Arrange
            int[][] nums = new int[][]
            {
                new int[]{ 3, 1, 2, 4, 5 },
                new int[]{ 1, 2, 3, 4 },
                new int[]{ 3, 4, 5, 6 }
            };

            IList<int> expected = new List<int> { 3, 4 };

            // Act
            var actual = solution.Intersection(nums);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void Intersection_Test2()
        {
            // Arrange
            int[][] nums = new int[][]
            {
                new int[]{ 1, 2, 3 },
                new int[]{ 4, 5, 6 }
            };

            IList<int> expected = new List<int> { };

            // Act
            var actual = solution.Intersection(nums);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}