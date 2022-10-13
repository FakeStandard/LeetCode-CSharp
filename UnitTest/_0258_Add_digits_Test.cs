using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0258.Add_digits;

namespace _0258.Add_digits.Tests
{
    [TestClass()]
    public class _0258_Add_digits_Test
    {
        _0258_Add_digits solution = new _0258_Add_digits();

        [TestMethod()]
        public void AddDigits_Test1()
        {
            // Arrange
            int num = 38;
            var expected = 2;

            // Act
            var actual = solution.AddDigits(num);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddDigits_Test2()
        {
            // Arrange
            int num = 0;
            var expected = 0;

            // Act
            var actual = solution.AddDigits(num);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}