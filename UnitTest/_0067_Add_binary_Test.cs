using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0067.Add_binary;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0067.Add_binary.Tests
{
    [TestClass()]
    public class _0067_Add_binary_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void AddBinary_Test1()
        {
            // Arrange
            string a = "11";
            string b = "1";
            var expected = "100";

            // Act
            var actual = solution.AddBinary(a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddBinary_Test2()
        {
            // Arrange
            string a = "1010";
            string b = "1011";
            var expected = "10101";

            // Act
            var actual = solution.AddBinary(a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}