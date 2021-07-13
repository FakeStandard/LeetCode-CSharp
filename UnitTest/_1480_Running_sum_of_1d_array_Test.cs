using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1480.Running_sum_of_1d_array;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;

namespace _1480.Running_sum_of_1d_array.Tests
{
    [TestClass()]
    public class _1480_Running_sum_of_1d_array_Test
    {
        _1480_Running_sum_of_1d_array solution = new _1480_Running_sum_of_1d_array();

        [TestMethod()]
        public void RunningSum_Test1()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4 };
            int[] expected = { 1, 3, 6, 10 };

            // Act
            var actual = solution.RunningSum(nums);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void RunningSum_Test2()
        {
            // Arrange
            int[] nums = { 1, 1, 1, 1, 1 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            var actual = solution.RunningSum(nums);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void RunningSum_Test3()
        {
            // Arrange
            int[] nums = { 3, 1, 2, 10, 1 };
            int[] expected = { 3, 4, 6, 16, 17 };

            // Act
            var actual = solution.RunningSum(nums);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}