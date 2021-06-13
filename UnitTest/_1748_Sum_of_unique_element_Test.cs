using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1748.Sum_of_unique_elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1748.Sum_of_unique_elements.Tests
{
    [TestClass()]
    public class _1748_Sum_of_unique_element_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void SumOfUnique_Test1()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 2 };
            var expected = 4;

            // Act
            var actual = solution.SumOfUnique(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SumOfUnique_Test2()
        {
            // Arrange
            int[] nums = { 1, 1, 1, 1, 1 };
            var expected = 0;

            // Act
            var actual = solution.SumOfUnique(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SumOfUnique_Test3()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 5 };
            var expected = 15;

            // Act
            var actual = solution.SumOfUnique(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}