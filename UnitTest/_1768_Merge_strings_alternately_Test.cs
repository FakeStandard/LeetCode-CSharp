using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1768.Merge_strings_alternately;

namespace _1768.Merge_strings_alternately.Tests
{
    [TestClass()]
    public class _1768_Merge_strings_alternately_Test
    {
        _1768_Merge_strings_alternately solution = new _1768_Merge_strings_alternately();

        [TestMethod()]
        public void MergeAlternately_Test1()
        {
            // Arrange
            string word1 = "abc";
            string word2 = "pqr";
            var expected = "apbqcr";

            // Act
            var actual = solution.MergeAlternately(word1, word2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MergeAlternately_Test2()
        {
            // Arrange
            string word1 = "ab";
            string word2 = "pqrs";
            var expected = "apbqrs";

            // Act
            var actual = solution.MergeAlternately(word1, word2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MergeAlternately_Test3()
        {
            // Arrange
            string word1 = "abcd";
            string word2 = "pq";
            var expected = "apbqcd";

            // Act
            var actual = solution.MergeAlternately(word1, word2);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}