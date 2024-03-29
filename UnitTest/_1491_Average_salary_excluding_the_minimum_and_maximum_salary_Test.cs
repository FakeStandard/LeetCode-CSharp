﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1491.Average_salary_excluding_the_minimum_and_maximum_salary;

namespace _1491.Average_salary_excluding_the_minimum_and_maximum_salary.Tests
{
    [TestClass()]
    public class _1491_Average_salary_excluding_the_minimum_and_maximum_salary_Test
    {
        _1491_Average_salary_excluding_the_minimum_and_maximum_salary solution = new _1491_Average_salary_excluding_the_minimum_and_maximum_salary();

        [TestMethod()]
        public void Average_Test1()
        {
            // Arrange
            int[] salary = { 4000, 3000, 1000, 2000 };
            var expected = 2500.00000;

            // Act
            var actual = solution.Average(salary);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Average_Test2()
        {
            // Arrange
            int[] salary = { 1000, 2000, 3000 };
            var expected = 2000.00000;

            // Act
            var actual = solution.Average(salary);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Average_Test3()
        {
            // Arrange
            int[] salary = { 6000, 5000, 4000, 3000, 2000, 1000 };
            var expected = 3500.00000;

            // Act
            var actual = solution.Average(salary);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Average_Test4()
        {
            // Arrange
            int[] salary = { 8000, 9000, 2000, 3000, 6000, 1000 };
            var expected = 4750.00000;

            // Act
            var actual = solution.Average(salary);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}