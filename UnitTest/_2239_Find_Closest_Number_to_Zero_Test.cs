using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._2239.Find_Closest_Number_to_Zero;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2239.Find_Closest_Number_to_Zero.Tests
{
    [TestClass()]
    public class _2239_Find_Closest_Number_to_Zero_Test
    {
        _2239_Find_Closest_Number_to_Zero solution = new _2239_Find_Closest_Number_to_Zero();

        [TestMethod()]
        public void FindClosestNumber_Test1()
        {
            // Arrange
            int[] nums = { -4, -2, 1, 4, 8 };
            int expected = 1;

            // Act
            var actual = solution.FindClosestNumber(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindClosestNumber_Test2()
        {
            // Arrange
            int[] nums = { 2, -1, 1 };
            int expected = 1;

            // Act
            var actual = solution.FindClosestNumber(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}