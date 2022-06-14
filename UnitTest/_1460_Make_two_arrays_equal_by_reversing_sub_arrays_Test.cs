using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1460.Make_two_arrays_equal_by_reversing_sub_arrays;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1460.Make_two_arrays_equal_by_reversing_sub_arrays.Tests
{
    [TestClass()]
    public class _1460_Make_two_arrays_equal_by_reversing_sub_arrays_Test
    {
        _1460_Make_two_arrays_equal_by_reversing_sub_arrays solution = new _1460_Make_two_arrays_equal_by_reversing_sub_arrays();

        [TestMethod()]
        public void CanBeEqual_Test1()
        {
            // Arrange
            int[] target = new int[] { 1, 2, 3, 4 };
            int[] arr = new int[] { 2, 4, 1, 3 };

            // Act
            var actual = solution.CanBeEqual(target, arr);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void CanBeEqual_Test2()
        {
            // Arrange
            int[] target = new int[] { 7 };
            int[] arr = new int[] { 7 };

            // Act
            var actual = solution.CanBeEqual(target, arr);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void CanBeEqual_Test3()
        {
            // Arrange
            int[] target = new int[] { 3, 7, 9 };
            int[] arr = new int[] { 3, 7, 11 };

            // Act
            var actual = solution.CanBeEqual(target, arr);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}