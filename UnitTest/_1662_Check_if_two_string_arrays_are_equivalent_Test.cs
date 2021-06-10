using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1662.Check_if_two_string_arrays_are_equivalent;

namespace _1662.Check_if_two_string_arrays_are_equivalent.Tests
{
    [TestClass()]
    public class _1662_Check_if_two_string_arrays_are_equivalent_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void ArrayStringsAreEqual_Test1()
        {
            // Arrange
            string[] word1 = { "ab", "c" };
            string[] word2 = { "a", "bc" };

            // Act
            var actual = solution.ArrayStringsAreEqual(word1, word2);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void ArrayStringsAreEqual_Test2()
        {
            // Arrange
            string[] word1 = { "a", "cb" };
            string[] word2 = { "ab", "c" };

            // Act
            var actual = solution.ArrayStringsAreEqual(word1, word2);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void ArrayStringsAreEqual_Test3()
        {
            // Arrange
            string[] word1 = { "abc", "d", "defg" };
            string[] word2 = { "abcddefg" };

            // Act
            var actual = solution.ArrayStringsAreEqual(word1, word2);

            // Assert
            Assert.IsTrue(actual);
        }
    }
}