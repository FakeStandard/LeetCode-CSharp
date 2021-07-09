using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0035.Search_insert_position;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Tests
{
    [TestClass()]
    public class _0035_Search_insert_position_Test
    {
        _0035_Search_insert_position solution = new _0035_Search_insert_position();

        [TestMethod()]
        public void SearchInsert_Test1()
        {
            // Arrange
            int[] nums = { 1, 3, 5, 6 };
            int target = 5;
            var expected = 2;

            // Act
            var actual = solution.SearchInsert(nums, target);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SearchInsert_Test2()
        {
            // Arrange
            int[] nums = { 1, 3, 5, 6 };
            int target = 2;
            var expected = 1;

            // Act
            var actual = solution.SearchInsert(nums, target);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SearchInsert_Test3()
        {
            // Arrange
            int[] nums = { 1, 3, 5, 6 };
            int target = 7;
            var expected = 4;

            // Act
            var actual = solution.SearchInsert(nums, target);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SearchInsert_Test4()
        {
            // Arrange
            int[] nums = { 1, 3, 5, 6 };
            int target = 0;
            var expected = 0;

            // Act
            var actual = solution.SearchInsert(nums, target);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SearchInsert_Test5()
        {
            // Arrange
            int[] nums = { 1 };
            int target = 0;
            var expected = 0;

            // Act
            var actual = solution.SearchInsert(nums, target);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}