using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1295.Find_numbers_with_even_number_of_digits;

namespace _1295.Find_numbers_with_even_number_of_digits.Tests
{
    [TestClass()]
    public class _1295_Find_numbers_with_even_number_of_digits_Test
    {
        _1295_Find_numbers_with_even_number_of_digits solution = new _1295_Find_numbers_with_even_number_of_digits();

        [TestMethod()]
        public void FindNumbers_Test1()
        {
            // Arrange
            int[] nums = new int[] { 12, 345, 2, 6, 7896 };
            var expected = 2;

            // Act
            var actual = solution.FindNumbers(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindNumbers_Test2()
        {
            // Arrange
            int[] nums = new int[] { 555, 901, 482, 1771 };
            var expected = 1;

            // Act
            var actual = solution.FindNumbers(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}