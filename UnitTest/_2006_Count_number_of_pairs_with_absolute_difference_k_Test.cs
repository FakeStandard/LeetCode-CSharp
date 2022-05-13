using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._2006.Count_number_of_pairs_with_absolute_difference_k;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2006.Count_number_of_pairs_with_absolute_difference_k.Tests
{
    [TestClass()]
    public class _2006_Count_number_of_pairs_with_absolute_difference_k_Test
    {
        _2006_Count_number_of_pairs_with_absolute_difference_k solution = new _2006_Count_number_of_pairs_with_absolute_difference_k();

        [TestMethod()]
        public void CountKDifference_Test1()
        {
            // Arrange
            int[] nums = new int[] { 1, 2, 2, 1 };
            int k = 1;
            int expected = 4;

            // Act
            var actual = solution.CountKDifference(nums, k);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountKDifference_Test2()
        {
            // Arrange
            int[] nums = new int[] { 1, 3 };
            int k = 3;
            int expected = 0;

            // Act
            var actual = solution.CountKDifference(nums, k);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountKDifference_Test3()
        {
            // Arrange
            int[] nums = new int[] { 3, 2, 1, 5, 4 };
            int k = 2;
            int expected = 3;

            // Act
            var actual = solution.CountKDifference(nums, k);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}