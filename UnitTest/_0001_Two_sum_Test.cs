using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Tests
{
    [TestClass()]
    public class _0001_Two_sum_Test
    {
        _0001_Two_sum solution = new _0001_Two_sum();

        [TestMethod()]
        public void TwoSum_Test1()
        {
            // Arrange
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            var expected = new int[] { 0, 1 };

            // Act
            var actual = solution.TwoSum(nums, target);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void TwoSum_Test2()
        {
            // Arrange
            int[] nums = { 3, 2, 4 };
            int target = 6;
            var expected = new int[] { 1, 2 };

            // Act
            var actual = solution.TwoSum(nums, target);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void TwoSum_Test3()
        {
            // Arrange
            int[] nums = { 3, 3 };
            int target = 6;
            var expected = new int[] { 0, 1 };

            // Act
            var actual = solution.TwoSum(nums, target);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}