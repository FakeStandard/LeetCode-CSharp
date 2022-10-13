using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1351.Count_negative_numbers_in_a_sorted_matrix;

namespace _1351.Count_negative_numbers_in_a_sorted_matrix.Tests
{
    [TestClass()]
    public class _1351_Count_negative_numbers_in_a_sorted_matrix_Test
    {
        _1351_Count_negative_numbers_in_a_sorted_matrix solution = new _1351_Count_negative_numbers_in_a_sorted_matrix();

        [TestMethod()]
        public void CountNegatives_Test1()
        {
            // Arrange
            int[][] grid = new int[][]
            {
                new int[]{ 4, 3, 2, -1 },
                new int[]{ 3, 2, 1, -1 },
                new int[]{ 1, 1, -1, -2 },
                new int[]{ -1, -1, -2, -3 }
            };

            var expected = 8;

            // Act
            var actual = solution.CountNegatives(grid);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountNegatives_Test2()
        {
            // Arrange
            int[][] grid = new int[][]
            {
                new int[]{ 3, 2 },
                new int[]{ 1, 0 }
            };

            var expected = 0;

            // Act
            var actual = solution.CountNegatives(grid);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountNegatives_Test3()
        {
            // Arrange
            int[][] grid = new int[][]
            {
                new int[]{ 1, -1 },
                new int[]{ -1, -1 }
            };

            var expected = 3;

            // Act
            var actual = solution.CountNegatives(grid);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountNegatives_Test4()
        {
            // Arrange
            int[][] grid = new int[][]
            {
                new int[]{ -1 }
            };

            var expected = 1;

            // Act
            var actual = solution.CountNegatives(grid);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}