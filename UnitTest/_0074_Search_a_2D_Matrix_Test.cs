using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0074.Search_a_2D_Matrix;

namespace _0074.Search_a_2D_Matrix.Tests
{
    [TestClass()]
    public class _0074_Search_a_2D_Matrix_Test
    {
        _0074_Search_a_2D_Matrix solution = new _0074_Search_a_2D_Matrix();

        [TestMethod()]
        public void SearchMatrix_Test1()
        {
            // Arrange
            int[][] matrix = new int[][] {
                new int[]{ 1, 3, 5, 7 },
                new int[]{ 10, 11, 16, 20 },
                new int[]{ 23, 30, 34, 60 },
            };
            int target = 3;

            // Act
            var actual = solution.SearchMatrix(matrix, target);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void SearchMatrix_Test2()
        {
            // Arrange
            int[][] matrix = new int[][] {
                new int[]{ 1, 3, 5, 7 },
                new int[]{ 10, 11, 16, 20 },
                new int[]{ 23, 30, 34, 60 },
            };
            int target = 13;

            // Act
            var actual = solution.SearchMatrix(matrix, target);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}