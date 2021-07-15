using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0611.Valid_triangel_number;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0611.Valid_triangel_number.Tests
{
    [TestClass()]
    public class _0611_Valid_triangle_number_Test
    {
        _0611_Valid_triangle_number solution = new _0611_Valid_triangle_number();

        [TestMethod()]
        public void TriangleNumber_Test1()
        {
            // Arrange
            int[] nums = { 2, 2, 3, 4 };
            int expected = 3;

            // Act
            var actual = solution.TriangleNumber(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TriangleNumber_Test2()
        {
            // Arrange
            int[] nums = { 4, 2, 3, 4 };
            int expected = 4;

            // Act
            var actual = solution.TriangleNumber(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}