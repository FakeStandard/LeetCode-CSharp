using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1281.Subtract_the_product_and_sum_of_digits_of_an_integer;

namespace _1281.Subtract_the_product_and_sum_of_digits_of_an_integer.Tests
{
    [TestClass()]
    public class _1281_Subtract_the_product_and_sum_of_digits_of_an_integer_Test
    {
        _1281_Subtract_the_product_and_sum_of_digits_of_an_integer solution = new _1281_Subtract_the_product_and_sum_of_digits_of_an_integer();

        [TestMethod()]
        public void SubtractProductAndSum_Test1()
        {
            // Arrange
            int n = 234;
            var expected = 15;

            // Act
            var actual = solution.SubtractProductAndSum(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SubtractProductAndSum_Test2()
        {
            // Arrange
            int n = 4421;
            var expected = 21;

            // Act
            var actual = solution.SubtractProductAndSum(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}