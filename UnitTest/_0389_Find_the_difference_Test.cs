using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0389.Find_the_difference;

namespace _0389.Find_the_difference.Tests
{
    [TestClass()]
    public class _0389_Find_the_difference_Test
    {
        _0389_Find_the_difference solution = new _0389_Find_the_difference();

        [TestMethod()]
        public void FindTheDifference_Test1()
        {
            // Arrange
            string s = "abcd";
            string t = "abcde";
            char expected = 'e';

            // Act
            var actual = solution.FindTheDifference(s, t);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindTheDifference_Test2()
        {
            // Arrange
            string s = "";
            string t = "y";
            char expected = 'y';

            // Act
            var actual = solution.FindTheDifference(s, t);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindTheDifference_Test3()
        {
            // Arrange
            string s = "a";
            string t = "aa";
            char expected = 'a';

            // Act
            var actual = solution.FindTheDifference(s, t);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindTheDifference_Test4()
        {
            // Arrange
            string s = "ae";
            string t = "aea";
            char expected = 'a';

            // Act
            var actual = solution.FindTheDifference(s, t);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}