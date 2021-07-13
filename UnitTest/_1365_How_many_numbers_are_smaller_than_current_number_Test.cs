using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1365.How_many_numbers_are_smaller_than_current_number;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;

namespace _1365.How_many_numbers_are_smaller_than_current_number.Tests
{
    [TestClass()]
    public class _1365_How_many_numbers_are_smaller_than_current_number_Test
    {
        _1365_How_many_numbers_are_smaller_than_current_number solution = new _1365_How_many_numbers_are_smaller_than_current_number();

        [TestMethod()]
        public void SmallerNumbersThanCurrent_Test1()
        {
            // Arrange
            int[] nums = { 8, 1, 2, 2, 3 };
            var expected = new int[] { 4, 0, 1, 1, 3 };

            // Act
            var actual = solution.SmallerNumbersThanCurrent(nums);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void SmallerNumbersThanCurrent_Test2()
        {
            // Arrange
            int[] nums = { 6, 5, 4, 8 };
            var expected = new int[] { 2, 1, 0, 3 };

            // Act
            var actual = solution.SmallerNumbersThanCurrent(nums);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void SmallerNumbersThanCurrent_Test3()
        {
            // Arrange
            int[] nums = { 7, 7, 7, 7 };
            var expected = new int[] { 0, 0, 0, 0 };

            // Act
            var actual = solution.SmallerNumbersThanCurrent(nums);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}