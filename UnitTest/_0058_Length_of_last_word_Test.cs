using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0058.Length_of_last_word;

namespace _0058.Length_of_last_word.Tests
{
    [TestClass()]
    public class _0058_Length_of_last_word_Test
    {
        _0058_Length_of_last_word solution = new _0058_Length_of_last_word();

        [TestMethod()]
        public void LengthOfLastWord_Test1()
        {
            // Arrange
            string s = "Hello World";
            var expected = 5;

            // Act
            var actual = solution.LengthOfLastWord(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LengthOfLastWord_Test2()
        {
            // Arrange
            string s = " ";
            var expected = 0;

            // Act
            var actual = solution.LengthOfLastWord(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}