using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0066.Plus_one;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Tests
{
    [TestClass()]
    public class _0066_Plus_one_Test
    {
        _0066_Plus_one solution = new _0066_Plus_one();

        [TestMethod()]
        public void PlusOne_Test1()
        {
            // Arrange
            int[] digits = { 1, 2, 3 };
            int[] expected = { 1, 2, 4 };

            // Act
            var actual = solution.PlusOne(digits);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void PlusOne_Test2()
        {
            // Arrange
            int[] digits = { 4, 3, 2, 1 };
            int[] expected = { 4, 3, 2, 2 };

            // Act
            var actual = solution.PlusOne(digits);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void PlusOne_Test3()
        {
            // Arrange
            int[] digits = { 0 };
            int[] expected = { 1 };

            // Act
            var actual = solution.PlusOne(digits);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}