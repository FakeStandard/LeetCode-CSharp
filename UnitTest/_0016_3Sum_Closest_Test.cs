using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0016._3Sum_closest;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0016._3Sum_closest.Tests
{
    [TestClass()]
    public class _0016_3Sum_Closest_Test
    {
        _0016_3Sum_closest solution = new _0016_3Sum_closest();

        [TestMethod()]
        public void ThreeSumClosest_Test1()
        {
            // Arrange
            int[] nums = { -1, 2, 1, -4 };
            int target = 4;
            var expected = 2;

            // Act
            var actual = solution.ThreeSumClosest(nums, target);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ThreeSumClosest_Test2()
        {
            // Arrange
            int[] nums = { 0, 0, 0 };
            int target = 1;
            var expected = 0;

            // Act
            var actual = solution.ThreeSumClosest(nums, target);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ThreeSumClosest_Test3()
        {
            // Arrange
            int[] nums = { -1, 2, -4, 1 };
            int target = 1;
            var expected = 2;

            // Act
            var actual = solution.ThreeSumClosest(nums, target);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}