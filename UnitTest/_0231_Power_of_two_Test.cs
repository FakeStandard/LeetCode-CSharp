using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0231.Power_of_two;

namespace _0231.Power_of_two.Tests
{
    [TestClass()]
    public class _0231_Power_of_two_Test
    {
        _0231_Power_of_two solution = new _0231_Power_of_two();

        [TestMethod()]
        public void IsPowerOfTwo_Test1()
        {
            // Arrange
            int n = 1;

            // Act
            var actual = solution.IsPowerOfTwo(n);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsPowerOfTwo_Test2()
        {
            // Arrange
            int n = 16;

            // Act
            var actual = solution.IsPowerOfTwo(n);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsPowerOfTwo_Test3()
        {
            // Arrange
            int n = 3;

            // Act
            var actual = solution.IsPowerOfTwo(n);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void IsPowerOfTwo_Test4()
        {
            // Arrange
            int n = 4;

            // Act
            var actual = solution.IsPowerOfTwo(n);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsPowerOfTwo_Test5()
        {
            // Arrange
            int n = 5;

            // Act
            var actual = solution.IsPowerOfTwo(n);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}