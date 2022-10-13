using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0032.Longest_valid_parentheses;

namespace _0032.Longest_valid_parentheses.Tests
{
    [TestClass()]
    public class _0032_Longest_valid_parentheses_Test
    {
        _0032_Longest_valid_parentheses solution = new _0032_Longest_valid_parentheses();

        [TestMethod()]
        public void LongestValidParentheses_Test1()
        {
            // Arrange
            string s = "(()";
            var expected = 2;

            // Act
            var actual = solution.LongestValidParentheses(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LongestValidParentheses_Test2()
        {
            // Arrange
            string s = ")()())";
            var expected = 4;

            // Act
            var actual = solution.LongestValidParentheses(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LongestValidParentheses_Test3()
        {
            // Arrange
            string s = "";
            var expected = 0;

            // Act
            var actual = solution.LongestValidParentheses(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LongestValidParentheses_Test4()
        {
            // Arrange
            string s = "()(()";
            var expected = 2;

            // Act
            var actual = solution.LongestValidParentheses(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}