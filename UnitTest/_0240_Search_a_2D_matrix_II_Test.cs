using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0240.Search_a_2D_matrix_II;

namespace _0240.Search_a_2D_matrix_II.Tests
{
    [TestClass()]
    public class _0240_Search_a_2D_matrix_II_Test
    {
        _0240_Search_a_2D_matrix_II solution = new _0240_Search_a_2D_matrix_II();

        [TestMethod()]
        public void SearchMatrix_Test1()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
                new int[]{ 1, 4, 7, 11, 15 },
                new int[]{ 2, 5, 8, 12, 19 },
                new int[]{ 3, 6, 9, 16, 22 },
                new int[]{ 10, 13, 14, 17, 24 },
                new int[]{ 18, 21, 23, 26, 30 },
            };

            int target = 5;

            // Act
            var actual = solution.SearchMatrix(matrix, target);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void SearchMatrix_Test2()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
                new int[]{ 1, 4, 7, 11, 15 },
                new int[]{ 2, 5, 8, 12, 19 },
                new int[]{ 3, 6, 9, 16, 22 },
                new int[]{ 10, 13, 14, 17, 24 },
                new int[]{ 18, 21, 23, 26, 30 },
            };

            int target = 20;

            // Act
            var actual = solution.SearchMatrix(matrix, target);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}