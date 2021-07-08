using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0718.Maximum_length_of_repeated_subarray;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0718.Maximum_length_of_repeated_subarray.Tests
{
    [TestClass()]
    public class _0718_Maximum_length_of_repeated_subarray_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void FindLength_Test1()
        {
            // Arrange
            int[] nums1 = { 1, 2, 3, 2, 1 };
            int[] nums2 = { 3, 2, 1, 4, 7 };
            var expected = 3;

            // Act
            var actual = solution.FindLength(nums1, nums2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindLength_Test2()
        {
            // Arrange
            int[] nums1 = { 0, 0, 0, 0, 0 };
            int[] nums2 = { 0, 0, 0, 0, 0 };
            var expected = 5;

            // Act
            var actual = solution.FindLength(nums1, nums2);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}