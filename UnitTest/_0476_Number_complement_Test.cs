using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0476.Number_complement;

namespace _0476.Number_complement.Tests
{
    [TestClass()]
    public class _0476_Number_complement_Test
    {
        _0476_Number_complement solution = new _0476_Number_complement();

        [TestMethod()]
        public void FindComplement_Test1()
        {
            // Arrange
            int num = 5;
            int expected = 2;

            // Act
            var actual = solution.FindComplement(num);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindComplement_Test2()
        {
            // Arrange
            int num = 1;
            int expected = 0;

            // Act
            var actual = solution.FindComplement(num);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}