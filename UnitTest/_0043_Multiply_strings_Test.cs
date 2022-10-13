using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0043.Multiply_strings;

namespace _0043.Multiply_strings.Tests
{
    [TestClass()]
    public class _0043_Multiply_strings_Test
    {
        _0043_Multiply_strings solution = new _0043_Multiply_strings();

        [TestMethod()]
        public void Multiply_Test1()
        {
            // Arrange
            string num1 = "2";
            string num2 = "3";
            string expected = "6";

            // Act
            var actual = solution.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Multiply_Test2()
        {
            // Arrange
            string num1 = "123";
            string num2 = "456";
            string expected = "56088";

            // Act
            var actual = solution.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Multiply_Test3()
        {
            // Arrange
            string num1 = "0";
            string num2 = "0";
            string expected = "0";

            // Act
            var actual = solution.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Multiply_Test4()
        {
            // Arrange
            string num1 = "9";
            string num2 = "9";
            string expected = "81";

            // Act
            var actual = solution.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Multiply_Test5()
        {
            // Arrange
            string num1 = "9133";
            string num2 = "0";
            string expected = "0";

            // Act
            var actual = solution.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}