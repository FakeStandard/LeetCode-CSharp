﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0168.Excel_sheet_column_title;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0168.Excel_sheet_column_title.Tests
{
    [TestClass()]
    public class _0168_Excel_sheet_column_title_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void ConvertToTitle_Test1()
        {
            // Arrange
            int columnNumber = 1;
            var expected = "A";

            // Act
            var actual = solution.ConvertToTitle(columnNumber);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ConvertToTitle_Test2()
        {
            // Arrange
            int columnNumber = 28;
            var expected = "AB";

            // Act
            var actual = solution.ConvertToTitle(columnNumber);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ConvertToTitle_Test3()
        {
            // Arrange
            int columnNumber = 701;
            var expected = "ZY";

            // Act
            var actual = solution.ConvertToTitle(columnNumber);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ConvertToTitle_Test4()
        {
            // Arrange
            int columnNumber = 2147483647;
            var expected = "FXSHRXW";

            // Act
            var actual = solution.ConvertToTitle(columnNumber);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}