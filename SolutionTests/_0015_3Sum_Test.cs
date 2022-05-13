using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0015._3Sum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0015._3Sum.Tests
{
    [TestClass()]
    public class _0015_3Sum_Test
    {
        _0015_3Sum solution = new _0015_3Sum();

        [TestMethod()]
        public void ThreeSum_Test1()
        {
            // Arrange
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            var expected = new int[][]
            {
                new int[]{ -1, -1, 2 },
                new int[]{ -1, 0, 1 },
            };

            // Act

            // Assert
        }
    }
}