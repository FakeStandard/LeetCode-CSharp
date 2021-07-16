using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0018._4Sum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0018._4Sum.Tests
{
    [TestClass()]
    public class _0018_4Sum_Test
    {
        _0018_4Sum solution = new _0018_4Sum();

        [TestMethod()]
        public void FourSum_Test1()
        {
            // Arrange
            int[] nums = { 1, 0, -1, 0, -2, 2 };
            int target = 0;
            IList<IList<int>> expected = new List<IList<int>>()
            {
                new List<int>(){ -2, -1, 1, 2 },
                new List<int>(){ -2, 0, 0, 2 },
                new List<int>(){ -1, 0, 0, 1 }
            };

            // Act
            var actual = solution.FourSum(nums, target);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void FourSum_Test2()
        {
            // Arrange
            int[] nums = { 2, 2, 2, 2, 2 };
            int target = 8;
            IList<IList<int>> expected = new List<IList<int>>()
            {
                new List<int>(){ 2, 2, 2, 2 }
            };

            // Act
            var actual = solution.FourSum(nums, target);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}