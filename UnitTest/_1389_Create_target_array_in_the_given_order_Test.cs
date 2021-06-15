using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1389.Create_target_array_in_the_given_order;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;

namespace _1389.Create_target_array_in_the_given_order.Tests
{
    [TestClass()]
    public class _1389_Create_target_array_in_the_given_order_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void CreateTargetArray_Test1()
        {
            // Arrange
            int[] nums = { 0, 1, 2, 3, 4 };
            int[] index = { 0, 1, 2, 2, 1 };
            var expected = new int[] { 0, 4, 1, 3, 2 };

            // Act
            var actual = solution.CreateTargetArray(nums, index);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void CreateTargetArray_Test2()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 0 };
            int[] index = { 0, 1, 2, 3, 0 };
            var expected = new int[] { 0, 1, 2, 3, 4 };

            // Act
            var actual = solution.CreateTargetArray(nums, index);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void CreateTargetArray_Test3()
        {
            // Arrange
            int[] nums = { 1 };
            int[] index = { 0 };
            var expected = new int[] { 1 };

            // Act
            var actual = solution.CreateTargetArray(nums, index);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}