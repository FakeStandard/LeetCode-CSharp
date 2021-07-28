using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1876.Substrings_of_size_three_with_distinct_characters;

namespace _1876.Substrings_of_size_three_with_distinct_characters.Tests
{
    [TestClass()]
    public class _1876_Substrings_of_size_three_with_distinct_characters_Test
    {
        _1876_Substrings_of_size_three_with_distinct_characters solution = new _1876_Substrings_of_size_three_with_distinct_characters();
     
        [TestMethod()]
        public void CountGoodSubstrings_Test1()
        {
            // Arrange
            string s = "xyzzaz";
            var expected = 1;

            // Act
            var actual = solution.CountGoodSubstrings(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountGoodSubstrings_Test2()
        {
            // Arrange
            string s = "aababcabc";
            var expected = 4;

            // Act
            var actual = solution.CountGoodSubstrings(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}