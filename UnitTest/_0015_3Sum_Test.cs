using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0015._3Sum;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0015._3Sum.Tests
{
    [TestClass()]
    public class _0015_3Sum_Test
    {
        _0015_3Sum solution = new _0015_3Sum();

        [TestMethod()]
        public void ThreeSum_Test1()
        {
            // Arrange
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            var expected = new int[][]
            {
                new int[]{ -1, -1, 2 },
                new int[]{ -1, 0, 1 },
            };

            // Act
            var actual = solution.ThreeSum(nums);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void ThreeSum_Test2()
        {
            // Arrange
            int[] nums = new int[] { };
            var expected = new int[] { };

            // Act
            var actual = solution.ThreeSum(nums);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void ThreeSum_Test3()
        {
            // Arrange
            int[] nums = new int[] { 0 };
            var expected = new int[] { };

            // Act
            var actual = solution.ThreeSum(nums);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}