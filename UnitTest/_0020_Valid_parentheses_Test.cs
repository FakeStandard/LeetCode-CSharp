using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0020.Valid_parentheses;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0020.Valid_parentheses.Tests
{
    [TestClass()]
    public class _0020_Valid_parentheses_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void IsValid_Test1()
        {
            // Arrange
            string s = "()";

            // Act
            var actual = solution.IsValid(s);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsValid_Test2()
        {
            // Arrange
            string s = "()[]{}";

            // Act
            var actual = solution.IsValid(s);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsValid_Test3()
        {
            // Arrange
            string s = "(]";

            // Act
            var actual = solution.IsValid(s);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void IsValid_Test4()
        {
            // Arrange
            string s = "([)]";

            // Act
            var actual = solution.IsValid(s);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void IsValid_Test5()
        {
            // Arrange
            string s = "{[]}";

            // Act
            var actual = solution.IsValid(s);

            // Assert
            Assert.IsTrue(actual);
        }
    }
}