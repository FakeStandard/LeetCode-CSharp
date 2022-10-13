using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0409.Longest_palindrome;

namespace _0409.Longest_palindrome.Tests
{
    [TestClass()]
    public class _0409_Longest_palindrome_Test
    {
        _0409_Longest_palindrome solution = new _0409_Longest_palindrome();

        [TestMethod()]
        public void LongestPalindrome_Test1()
        {
            // Arrange
            string s = "abccccdd";
            var expected = 7;

            // Act
            var actual = solution.LongestPalindrome(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LongestPalindrome_Test2()
        {
            // Arrange
            string s = "a";
            var expected = 1;

            // Act
            var actual = solution.LongestPalindrome(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LongestPalindrome_Test3()
        {
            // Arrange
            string s = "bb";
            var expected = 2;

            // Act
            var actual = solution.LongestPalindrome(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}