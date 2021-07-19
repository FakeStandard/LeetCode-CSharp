using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1832.Check_if_the_sentence_is_pangram;

namespace _1832.Check_if_the_sentence_is_pangram.Tests
{
    [TestClass()]
    public class _1832_Check_if_the_sentence_is_pangram_Test
    {
        _1832_Check_if_the_sentence_is_pangram solution = new _1832_Check_if_the_sentence_is_pangram();

        [TestMethod()]
        public void CheckIfPangram_Test1()
        {
            // Arrange
            string sentence = "thequickbrownfoxjumpsoverthelazydog";

            // Act
            var actual = solution.CheckIfPangram(sentence);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void CheckIfPangram_Test2()
        {
            // Arrange
            string sentence = "leetcode";

            // Act
            var actual = solution.CheckIfPangram(sentence);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}