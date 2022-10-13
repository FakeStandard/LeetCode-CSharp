using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1047.Remove_all_adjacent_duplicates_in_string;

namespace _1047.Remove_all_adjacent_duplicates_in_string.Tests
{
    [TestClass()]
    public class _1047_Remove_all_adjacent_duplicates_in_string_Test
    {
        _1047_Remove_all_adjacent_duplicates_in_string solution = new _1047_Remove_all_adjacent_duplicates_in_string();

        [TestMethod()]
        public void RemoveDuplicates_Test1()
        {
            // Arrange
            string s = "abbaca";
            var expected = "ca";

            // Act
            var actual = solution.RemoveDuplicates(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RemoveDuplicates_Test2()
        {
            // Arrange
            string s = "azxxzy";
            var expected = "ay";

            // Act
            var actual = solution.RemoveDuplicates(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}