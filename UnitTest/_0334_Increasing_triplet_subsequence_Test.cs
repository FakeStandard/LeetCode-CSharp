using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0334.Increasing_triplet_subsequence;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0334.Increasing_triplet_subsequence.Tests
{
    [TestClass()]
    public class _0334_Increasing_triplet_subsequence_Test
    {
        _0334_Increasing_triplet_subsequence solution = new _0334_Increasing_triplet_subsequence();

        [TestMethod()]
        public void IncreasingTriplet_Test1()
        {
            // Arrange
            int[] nums = new int[] { 1, 2, 3, 4, 5 };

            // Act
            var actual = solution.IncreasingTriplet(nums);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IncreasingTriplet_Test2()
        {
            // Arrange
            int[] nums = new int[] { 5, 4, 3, 2, 1 };

            // Act
            var actual = solution.IncreasingTriplet(nums);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void IncreasingTriplet_Test3()
        {
            // Arrange
            int[] nums = new int[] { 2, 1, 5, 0, 4, 6 };

            // Act
            var actual = solution.IncreasingTriplet(nums);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IncreasingTriplet_Test4()
        {
            // Arrange
            int[] nums = new int[] { 20, 100, 10, 12, 5, 13 };

            // Act
            var actual = solution.IncreasingTriplet(nums);

            // Assert
            Assert.IsTrue(actual);
        }
    }
}