using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1816.Truncate_sentence;

namespace _1816.Truncate_sentence.Tests
{
    [TestClass()]
    public class _1816_Truncate_sentence_Test
    {
        _1816_Truncate_sentence solution = new _1816_Truncate_sentence();

        [TestMethod()]
        public void TruncateSentence_Test1()
        {
            // Arrange
            string s = "Hello how are you Contestant";
            int k = 4;
            var expected = "Hello how are you";

            // Act
            var actual = solution.TruncateSentence(s, k);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TruncateSentence_Test2()
        {
            // Arrange
            string s = "What is the solution to this problem";
            int k = 4;
            var expected = "What is the solution";

            // Act
            var actual = solution.TruncateSentence(s, k);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TruncateSentence_Test3()
        {
            // Arrange
            string s = "chopper is not a tanuki";
            int k = 5;
            var expected = "chopper is not a tanuki";

            // Act
            var actual = solution.TruncateSentence(s, k);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}