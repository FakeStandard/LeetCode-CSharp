using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1700.Number_of_students_unabled_to_eat_lunch;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1700.Number_of_students_unabled_to_eat_lunch.Tests
{
    [TestClass()]
    public class _1700_Number_of_students_unable_to_eat_lunch_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void CountStudents_Test1()
        {
            // Arrange
            int[] students = { 1, 1, 0, 0 };
            int[] sandwiches = { 0, 1, 0, 1 };
            var expected = 0;

            // Act
            var actual = solution.CountStudents(students, sandwiches);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountStudents_Test2()
        {
            // Arrange
            int[] students = { 1, 1, 1, 0, 0, 1 };
            int[] sandwiches = { 1, 0, 0, 0, 1, 1 };
            var expected = 3;

            // Act
            var actual = solution.CountStudents(students, sandwiches);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}