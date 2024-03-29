﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1342.Number_of_steps_to_reduce_a_number_to_zero;

namespace _1342.Number_of_steps_to_reduce_a_number_to_zero.Tests
{
    [TestClass()]
    public class _1342_Number_of_steps_to_reduce_a_number_to_zero_Test
    {
        _1342_Number_of_steps_to_reduce_a_number_to_zero solution = new _1342_Number_of_steps_to_reduce_a_number_to_zero();

        [TestMethod()]
        public void NumberOfSteps_Test1()
        {
            // Arrange
            int num = 14;
            var expected = 6;

            // Act
            var actual = solution.NumberOfSteps(num);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NumberOfSteps_Test2()
        {
            // Arrange
            int num = 8;
            var expected = 4;

            // Act
            var actual = solution.NumberOfSteps(num);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NumberOfSteps_Test3()
        {
            // Arrange
            int num = 123;
            var expected = 12;

            // Act
            var actual = solution.NumberOfSteps(num);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}