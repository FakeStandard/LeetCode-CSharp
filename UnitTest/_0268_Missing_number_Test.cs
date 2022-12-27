using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0268.Missing_number;

namespace _0268.Missing_number.Tests
{
    [TestClass()]
    public class _0268_Missing_number_Test
    {
        _0268_Missing_number solution = new _0268_Missing_number();

        [TestMethod()]
        public void MissingNumber_Test1()
        {
            // Arrange
            int[] nums = { 3, 0, 1 };
            int expected = 2;

            // Act
            var actual = solution.MissingNumber(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MissingNumber_Test2()
        {

            // Arrange
            int[] nums = { 0, 1 };
            int expected = 2;

            // Act
            var actual = solution.MissingNumber(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MissingNumber_Test3()
        {

            // Arrange
            int[] nums = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            int expected = 8;

            // Act
            var actual = solution.MissingNumber(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}