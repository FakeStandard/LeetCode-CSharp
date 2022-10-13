using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1380.Lucky_numbers_in_a_matrix;
using System.Collections.Generic;
using FluentAssertions;

namespace _1380.Lucky_numbers_in_a_matrix.Tests
{
    [TestClass()]
    public class _1380_Lucky_numbers_in_a_matrix_Test
    {
        _1380_Lucky_numbers_in_a_matrix solution = new _1380_Lucky_numbers_in_a_matrix();

        [TestMethod()]
        public void LuckyNumbers_Test1()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
                new int[]{ 3, 7, 8 },
                new int[]{ 9, 11, 13 },
                new int[]{ 15, 16, 17 }
            };

            IList<int> expected = new List<int> { 15 };

            // Act
            var actual = solution.LuckyNumbers(matrix);

            // Assert
            actual.Should().BeEquivalentTo(expected);
            //Assert.ReferenceEquals(expected, actual);
        }

        [TestMethod()]
        public void LuckyNumbers_Test2()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
                new int[]{ 1, 10, 4, 2 },
                new int[]{ 9, 3, 8, 7 },
                new int[]{ 15, 16, 17, 12 }
            };

            IList<int> expected = new List<int> { 12 };

            // Act
            var actual = solution.LuckyNumbers(matrix);

            // Assert
            actual.Should().BeEquivalentTo(expected);
            //Assert.ReferenceEquals(expected, actual);
        }

        [TestMethod()]
        public void LuckyNumbers_Test3()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
                new int[]{ 7, 8 },
                new int[]{ 1, 2, }
            };

            IList<int> expected = new List<int> { 7 };

            // Act
            var actual = solution.LuckyNumbers(matrix);

            // Assert
            actual.Should().BeEquivalentTo(expected);
            //Assert.ReferenceEquals(expected, actual);
        }
    }
}