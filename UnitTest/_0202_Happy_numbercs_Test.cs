using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0202.Happy_number;

namespace _0202.Happy_number.Tests
{
    [TestClass()]
    public class _0202_Happy_numbercs_Test
    {
        _0202_Happy_numbercs solution = new _0202_Happy_numbercs();

        [TestMethod()]
        public void IsHappy_Test1()
        {
            // Arrange
            int n = 10;

            // Act
            bool actual = solution.IsHappy(n);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsHappy_Test2()
        {
            // Arrange
            int n = 2;

            // Act
            bool actual = solution.IsHappy(n);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}