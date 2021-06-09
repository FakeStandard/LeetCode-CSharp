using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1543.Count_good_triplets;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1543.Count_good_triplets.Tests
{
    [TestClass()]
    public class _1543_Count_good_triplets_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void CountGoodTriplets_Test1()
        {
            // Arrange
            int[] arr = { 3, 0, 1, 1, 9, 7 };
            int a = 7;
            int b = 2;
            int c = 3;
            var expected = 4;

            // Act
            var actual = solution.CountGoodTriplets(arr, a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountGoodTriplets_Test2()
        {
            // Arrange
            int[] arr = { 1, 1, 2, 2, 3 };
            int a = 0;
            int b = 0;
            int c = 1;
            var expected = 0;

            // Act
            var actual = solution.CountGoodTriplets(arr, a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}