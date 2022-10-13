using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0118.Pascals_triangle;

namespace _0118.Pascals_triangle.Tests
{
    [TestClass()]
    public class _0118_Pascals_triangle_Test
    {
        _0118_Pascals_triangle solution = new _0118_Pascals_triangle();

        [TestMethod()]
        public void Generate_Test1()
        {
            // Arrange
            int numRows = 5;
            var expected = new int[][]
            {
                new int[]{ 1 },
                new int[]{ 1, 1 },
                new int[]{ 1, 2, 1 },
                new int[]{ 1, 3, 3, 1 },
                new int[]{ 1, 4, 6, 4, 1 },
            };

            // Act
            var actual = solution.Generate(numRows);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void Generate_Test2()
        {
            // Arrange
            int numRows = 1;
            var expected = new int[][]
            {
                new int[]{ 1 },
            };

            // Act
            var actual = solution.Generate(numRows);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}