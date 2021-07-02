using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0070.Climbing_stairs;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0070.Climbing_stairs.Tests
{
    [TestClass()]
    public class _0070_Climbing_stairs_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void ClimbStairs_Test1()
        {
            // Arrange
            int n = 2;
            var expected = 2;

            // Act
            var actual = solution.ClimbStairs(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ClimbStairs_Test2()
        {
            // Arrange
            int n = 3;
            var expected = 3;

            // Act
            var actual = solution.ClimbStairs(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}