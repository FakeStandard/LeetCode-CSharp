using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0542._01_Matrix;

namespace _0542._01_Matrix.Tests
{
    [TestClass()]
    public class _0542_01_Matrix_Test
    {
        _0542_01_Matrix solution = new _0542_01_Matrix();

        [TestMethod()]
        public void UpdateMatrix_Test1()
        {
            // Arrange
            int[][] max = new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 0 },
                new int[] { 0, 0, 0 },
            };

            var expected = new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 0 },
                new int[] { 0, 0, 0 },
            };

            // Act
            var actual = solution.UpdateMatrix(max);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void UpdateMatrix_Test2()
        {
            // Arrange
            int[][] max = new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 0 },
                new int[] { 1, 1, 1 },
            };

            var expected = new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 0 },
                new int[] { 1, 2, 1 },
            };

            // Act
            var actual = solution.UpdateMatrix(max);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}