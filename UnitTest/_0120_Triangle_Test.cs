using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0120.Triangle;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0120.Triangle.Tests
{
    [TestClass()]
    public class _0120_Triangle_Test
    {
        _0120_Triangle solution = new _0120_Triangle();

        [TestMethod()]
        public void MinimumTotal_Test1()
        {
            // Arrange
            int[][] triangle ={
                new int[] { 2 },
                new int[] { 3, 4 },
                new int[] { 6,5,7 },
                new int[] { 4,1,8,3 },
            };

            int expected = 11;

            // Act
            var actual = solution.MinimumTotal(triangle);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinimumTotal_Test2()
        {
            // Arrange
            int[][] triangle ={
                new int[] { -10 },
            };

            int expected = -10;

            // Act
            var actual = solution.MinimumTotal(triangle);

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void MinimumTotal_Test3()
        {
            // Arrange
            int[][] triangle ={
                new int[] { -1 },
                new int[] { 2, 3 },
                new int[] { 1, -1, 3 },
            };

            int expected = 0;

            // Act
            var actual = solution.MinimumTotal(triangle);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}