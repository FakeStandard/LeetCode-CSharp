using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0326.Power_of_three;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0326.Power_of_three.Tests
{
    [TestClass()]
    public class _0326_Power_of_three_Test
    {
        _0326_Power_of_three solution = new _0326_Power_of_three();

        [TestMethod()]
        public void IsPowerOfThree_Test1()
        {
            // Arrange
            int n = 27;

            // Act
            var actual = solution.IsPowerOfThree(n);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsPowerOfThree_Test2()
        {
            // Arrange
            int n = 0;

            // Act
            var actual = solution.IsPowerOfThree(n);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void IsPowerOfThree_Test3()
        {
            // Arrange
            int n = 9;

            // Act
            var actual = solution.IsPowerOfThree(n);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsPowerOfThree_Test4()
        {
            // Arrange
            int n = 45;

            // Act
            var actual = solution.IsPowerOfThree(n);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}