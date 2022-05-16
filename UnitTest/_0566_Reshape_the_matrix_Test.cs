using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0566.Reshape_the_matrix;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0566.Reshape_the_matrix.Tests
{
    [TestClass()]
    public class _0566_Reshape_the_matrix_Test
    {
        _0566_Reshape_the_matrix solution = new _0566_Reshape_the_matrix();

        [TestMethod()]
        public void MatrixReshape_Test1()
        {
            // Arrange
            int[][] nums = new int[][]
            {
                new int[]{ 1, 2 },
                new int[]{ 3, 4 },
            };

            int r = 1;
            int c = 4;
            var expected = new int[][] { new int[] { 1, 2, 3, 4 } };

            // Act
            var actual = solution.MatrixReshape(nums, r, c);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void MatrixReshape_Test2()
        {
            // Arrange
            int[][] nums = new int[][]
            {
                new int[]{ 1, 2 },
                new int[]{ 3, 4 },
            };

            int r = 2;
            int c = 4;
            var expected = new int[][]
            {
                new int[]{ 1, 2 },
                new int[]{ 3, 4 },
            };

            // Act
            var actual = solution.MatrixReshape(nums, r, c);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}