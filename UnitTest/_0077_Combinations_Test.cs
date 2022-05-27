using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0077.Combinations;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0077.Combinations.Tests
{
    [TestClass()]
    public class _0077_Combinations_Test
    {
        _0077_Combinations solution = new _0077_Combinations();

        [TestMethod()]
        public void Combine_Test1()
        {
            // Arrange
            int n = 4;
            int k = 2;
            var expected = new int[][]
            {
                new int[]{ 1, 2 },
                new int[]{ 1, 3 },
                new int[]{ 1, 4 },
                new int[]{ 2, 3 },
                new int[]{ 2, 4 },
                new int[]{ 3, 4 },
            };

            // Act
            var actual = solution.Combine(n, k);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void Combine_Test2()
        {
            // Arrange
            int n = 1;
            int k = 1;
            var expected = new int[][]
            {
                new int[]{ 1 },
            };

            // Act
            var actual = solution.Combine(n, k);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}