using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0415.Add_strings;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0415.Add_strings.Tests
{
    [TestClass()]
    public class _0415_Add_strings_Test
    {
        _0415_Add_strings soluton = new _0415_Add_strings();

        [TestMethod()]
        public void AddStrings_Test1()
        {
            // Arrange
            string num1 = "11";
            string num2 = "123";
            string expected = "134";

            // Act
            var actual = soluton.AddStrings(num1, num2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddStrings_Test2()
        {
            // Arrange
            string num1 = "456";
            string num2 = "77";
            string expected = "533";

            // Act
            var actual = soluton.AddStrings(num1, num2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddStrings_Test3()
        {
            // Arrange
            string num1 = "0";
            string num2 = "0";
            string expected = "0";

            // Act
            var actual = soluton.AddStrings(num1, num2);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}