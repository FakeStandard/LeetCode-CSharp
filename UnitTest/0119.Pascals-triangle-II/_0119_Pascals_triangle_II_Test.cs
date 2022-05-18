using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0119.Pascals_triangle_II;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0119.Pascals_triangle_II.Tests
{
    [TestClass()]
    public class _0119_Pascals_triangle_II_Test
    {
        _0119_Pascals_triangle_II solution = new _0119_Pascals_triangle_II();

        [TestMethod()]
        public void GetRow_Test1()
        {
            // Arrange
            int rowIndex = 3;
            var expected = new List<int>() { 1, 3, 3, 1 };

            // Act
            var actual = solution.GetRow(rowIndex);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void GetRow_Test2()
        {
            // Arrange
            int rowIndex = 0;
            var expected = new List<int>() { 1 };

            // Act
            var actual = solution.GetRow(rowIndex);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void GetRow_Test3()
        {
            // Arrange
            int rowIndex = 1;
            var expected = new List<int>() { 1, 1 };

            // Act
            var actual = solution.GetRow(rowIndex);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}