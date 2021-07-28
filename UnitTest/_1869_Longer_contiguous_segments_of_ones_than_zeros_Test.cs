using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1869.Longer_contiguous_segments_of_ones_than_zeros;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1869.Longer_contiguous_segments_of_ones_than_zeros.Tests
{
    [TestClass()]
    public class _1869_Longer_contiguous_segments_of_ones_than_zeros_Test
    {
        _1869_Longer_contiguous_segments_of_ones_than_zeros solution = new _1869_Longer_contiguous_segments_of_ones_than_zeros();

        [TestMethod()]
        public void CheckZeroOnes_Test1()
        {
            // Arrange
            string s = "1101";

            // Act
            var actual = solution.CheckZeroOnes(s);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void CheckZeroOnes_Test2()
        {
            // Arrange
            string s = "111000";

            // Act
            var actual = solution.CheckZeroOnes(s);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void CheckZeroOnes_Test3()
        {
            // Arrange
            string s = "110100010";

            // Act
            var actual = solution.CheckZeroOnes(s);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}