using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1844.Replace_all_digits_with_characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1844.Replace_all_digits_with_characters.Tests
{
    [TestClass()]
    public class _1844_Replace_all_digits_with_characters_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void ReplaceDigits_Test1()
        {
            // Arrange
            string s = "a1c1e1";
            var expected = "abcdef";

            // Act
            var actual = solution.ReplaceDigits(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ReplaceDigits_Test2()
        {
            // Arrange
            string s = "a1b2c3d4e";
            var expected = "abbdcfdhe";

            // Act
            var actual = solution.ReplaceDigits(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}