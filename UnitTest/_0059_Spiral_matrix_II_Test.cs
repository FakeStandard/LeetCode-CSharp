using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0059.Spiral_matrix_II;

namespace _0059.Spiral_matrix_II.Tests
{
    [TestClass()]
    public class _0059_Spiral_matrix_II_Test
    {
        _0059_Spiral_matrix_II solution = new _0059_Spiral_matrix_II();

        [TestMethod()]
        public void GenerateMatrix_Test1()
        {
            // Arrange
            int n = 3;
            var expected = new int[][]
            {
                new int[]{ 1, 2, 3, },
                new int[]{ 8, 9, 4, },
                new int[]{ 7, 6, 5, },
            };

            // Act
            var actual = solution.GenerateMatrix(n);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void GenerateMatrix_Test2()
        {
            // Arrange
            int n = 1;
            var expected = new int[][]
            {
                new int[]{ 1 },
            };

            // Act
            var actual = solution.GenerateMatrix(n);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}