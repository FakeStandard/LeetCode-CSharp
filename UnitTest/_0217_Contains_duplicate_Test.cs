using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0217.Contains_Duplicate;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0217.Contains_Duplicate.Tests
{
    [TestClass()]
    public class _0217_Contains_duplicate_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void ContainsDuplicate_Test1()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 1 };

            // Act
            var actual = solution.ContainsDuplicate(nums);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void ContainsDuplicate_Test2()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4 };

            // Act
            var actual = solution.ContainsDuplicate(nums);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void ContainsDuplicate_Test3()
        {
            // Arrange
            int[] nums = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

            // Act
            var actual = solution.ContainsDuplicate(nums);

            // Assert
            Assert.IsTrue(actual);
        }
    }
}