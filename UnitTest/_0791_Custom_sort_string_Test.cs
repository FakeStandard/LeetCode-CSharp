using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0791.Custom_sort_string;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0791.Custom_sort_string.Tests
{
    [TestClass()]
    public class _0791_Custom_sort_string_Test
    {
        _0791_Custom_sort_string solution = new _0791_Custom_sort_string();

        [TestMethod()]
        public void CustomSortString_Test1()
        {
            // Arrange
            string order = "cba";
            string str = "abcd";
            var expected = "cbad";

            // Act
            var actual = solution.CustomSortString(order, str);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CustomSortString_Test2()
        {
            // Arrange
            string order = "cbafg";
            string str = "abcd";
            var expected = "cbad";

            // Act
            var actual = solution.CustomSortString(order, str);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}