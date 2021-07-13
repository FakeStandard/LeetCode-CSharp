using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1523.Count_odd_numbers_in_an_interval_range;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1523.Count_odd_numbers_in_an_interval_range.Tests
{
    [TestClass()]
    public class _1523_Count_odd_numbers_in_an_interval_range_Test
    {
        _1523_Count_odd_numbers_in_an_interval_range solution = new _1523_Count_odd_numbers_in_an_interval_range();

        [TestMethod()]
        public void CountOdds_Test1()
        {
            // Arrange
            int low = 3;
            int high = 7;
            var expected = 3;

            // Act
            var actual = solution.CountOdds(low, high);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountOdds_Test2()
        {
            // Arrange
            int low = 8;
            int high = 10;
            var expected = 1;

            // Act
            var actual = solution.CountOdds(low, high);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountOdds_Test3()
        {
            // Arrange
            int low = 407656828;
            int high = 722359384;
            var expected = 157351278;

            // Act
            var actual = solution.CountOdds(low, high);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}