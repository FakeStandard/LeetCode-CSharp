using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0350.Intersection_of_two_arraysII;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0350.Intersection_of_two_arraysII.Tests
{
    [TestClass()]
    public class _0350_Intersection_of_two_arraysII_Test
    {
        _0350_Intersection_of_two_arraysII solution = new _0350_Intersection_of_two_arraysII();

        [TestMethod()]
        public void Intersect_Test1()
        {
            // Arrange
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };
            int[] expected = { 2, 2 };

            // Act
            var actual = solution.Intersect(nums1, nums2);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void Intersect_Test2()
        {
            // Arrange
            int[] nums1 = { 4, 9, 5 };
            int[] nums2 = { 9, 4, 9, 8, 4 };
            int[] expected = { 4, 9 };

            // Act
            var actual = solution.Intersect(nums1, nums2);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}