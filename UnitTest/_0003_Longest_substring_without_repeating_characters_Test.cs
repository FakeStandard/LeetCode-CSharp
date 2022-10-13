using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0003.Longest_substring_without_repeating_characters;

namespace _0003.Longest_substring_without_repeating_characters.Tests
{
    [TestClass()]
    public class _0003_Longest_substring_without_repeating_characters_Test
    {
        _0003_Longest_substring_without_repeating_characters solution = new _0003_Longest_substring_without_repeating_characters();

        [TestMethod()]
        public void LengthOfLongestSubstring_Test1()
        {
            // Arrange
            string s = "abcabcbb";
            var expected = 3;

            // Act
            var actual = solution.LengthOfLongestSubstring(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LengthOfLongestSubstring_Test2()
        {
            // Arrange
            string s = "bbbbb";
            var expected = 1;

            // Act
            var actual = solution.LengthOfLongestSubstring(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LengthOfLongestSubstring_Test3()
        {
            // Arrange
            string s = "pwwkew";
            var expected = 3;

            // Act
            var actual = solution.LengthOfLongestSubstring(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LengthOfLongestSubstring_Test4()
        {
            // Arrange
            string s = "au";
            var expected = 2;

            // Act
            var actual = solution.LengthOfLongestSubstring(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LengthOfLongestSubstring_Test5()
        {
            // Arrange
            string s = "dvdf";
            var expected = 3;

            // Act
            var actual = solution.LengthOfLongestSubstring(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}