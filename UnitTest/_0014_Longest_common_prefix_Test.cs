using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0014.Longest_common_prefix;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0014.Longest_common_prefix.Tests
{
    [TestClass()]
    public class _0014_Longest_common_prefix_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void LongestCommonPrefix_Test1()
        {
            // Arrange
            string[] strs = { "flower", "flow", "flight" };
            var expected = "fl";

            // Act
            var actual = solution.LongestCommonPrefix(strs);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LongestCommonPrefix_Test2()
        {
            // Arrange
            string[] strs = { "dog", "racecar", "car" };
            var expected = "";

            // Act
            var actual = solution.LongestCommonPrefix(strs);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}