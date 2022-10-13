using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0709.To_lower_case;

namespace _0709.To_lower_case.Tests
{
    [TestClass()]
    public class _0709_To_lower_case_Test
    {
        _0709_To_lower_case solution = new _0709_To_lower_case();

        [TestMethod()]
        public void ToLowerCase_Test1()
        {
            // Arrange
            string s = "Hello";
            var expected = "hello";

            // Act
            var actual = solution.ToLowerCase(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToLowerCase_Test2()
        {
            // Arrange
            string s = "here";
            var expected = "here";

            // Act
            var actual = solution.ToLowerCase(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToLowerCase_Test3()
        {
            // Arrange
            string s = "LOVELY";
            var expected = "lovely";

            // Act
            var actual = solution.ToLowerCase(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}