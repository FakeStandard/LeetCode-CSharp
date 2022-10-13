using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1249.Minimum_remove_to_make_valid_parentheses;

namespace _1249.Minimum_remove_to_make_valid_parentheses.Tests
{
    [TestClass()]
    public class _1249_Minimum_remove_to_make_valid_parentheses_Test
    {
        _1249_Minimum_remove_to_make_valid_parentheses solution = new _1249_Minimum_remove_to_make_valid_parentheses();

        [TestMethod()]
        public void MinRemoveToMakeValid_Test1()
        {
            // Arrange
            string s = "lee(t(c)o)de)";
            string expected = "lee(t(c)o)de";

            // Act
            var actual = solution.MinRemoveToMakeValid(s);

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void MinRemoveToMakeValid_Test2()
        {
            // Arrange
            string s = "a)b(c)d";
            string expected = "ab(c)d";

            // Act
            var actual = solution.MinRemoveToMakeValid(s);

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void MinRemoveToMakeValid_Test3()
        {
            // Arrange
            string s = "a)b(c)d";
            string expected = "ab(c)d";

            // Act
            var actual = solution.MinRemoveToMakeValid(s);

            // Assert
            Assert.AreEqual(actual, expected);
        }
    }
}