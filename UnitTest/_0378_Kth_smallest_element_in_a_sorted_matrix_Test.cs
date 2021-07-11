using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0378.Kth_smallest_element_in_a_sorted_matrix;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0378.Kth_smallest_element_in_a_sorted_matrix.Tests
{
    [TestClass()]
    public class _0378_Kth_smallest_element_in_a_sorted_matrix_Test
    {
        _0378_Kth_smallest_element_in_a_sorted_matrix solution = new _0378_Kth_smallest_element_in_a_sorted_matrix();

        [TestMethod()]
        public void KthSmallest_Test1()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
                new int[]{ 1, 5, 9 },
                new int[]{ 10, 11, 13 },
                new int[]{ 12, 13, 15 }
            };

            int k = 8;
            var expected = 13;

            // Act
            var actual = solution.KthSmallest(matrix, k);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void KthSmallest_Test2()
        {
            // Arrange
            int[][] matrix = new int[][]
            {
                new int[]{ -5 }
            };

            int k = 1;
            var expected = -5;

            // Act
            var actual = solution.KthSmallest(matrix, k);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}