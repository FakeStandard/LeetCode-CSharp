using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0007.Reverse_integer;

namespace _0007.Reverse_integer.Tests
{
    [TestClass()]
    public class _0007_Reverse_integer_Test
    {
        _0007_Reverse_integer solution = new _0007_Reverse_integer();

        [TestMethod()]
        public void Reverse_Test1()
        {
            // Arrange
            int x = 123;
            var expected = 321;

            // Act
            var actual = solution.Reverse(x);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Reverse_Test2()
        {
            // Arrange
            int x = -123;
            var expected = -321;

            // Act
            var actual = solution.Reverse(x);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Reverse_Test3()
        {
            // Arrange
            int x = 120;
            var expected = 21;

            // Act
            var actual = solution.Reverse(x);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Reverse_Test4()
        {
            // Arrange
            int x = 0;
            var expected = 0;

            // Act
            var actual = solution.Reverse(x);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}