using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0912.Sort_an_array;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;

namespace _0912.Sort_an_array.Tests
{
    [TestClass()]
    public class _0912_Sort_an_array_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void SortArray_Test1()
        {
            // Arrange
            int[] nums = { 5, 2, 3, 1 };
            var expected = new int[] { 1, 2, 3, 5 };

            // Act
            var actual = solution.SortArray(nums);

            // Assert
            //Assert.ReferenceEquals(expected, actual);
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void SortArray_Test2()
        {
            // Arrange
            int[] nums = { 5, 1, 1, 2, 0, 0 };
            var expected = new int[] { 0, 0, 1, 1, 2, 5 };

            // Act
            var actual = solution.SortArray(nums);

            // Assert
            //Assert.ReferenceEquals(expected, actual);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}