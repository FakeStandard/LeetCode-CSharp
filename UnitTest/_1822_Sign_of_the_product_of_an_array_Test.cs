using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1822.Sign_of_the_product_of_an_array;

namespace _1822.Sign_of_the_product_of_an_array.Tests
{
    [TestClass()]
    public class _1822_Sign_of_the_product_of_an_array_Test
    {
        _1822_Sign_of_the_product_of_an_array solution = new _1822_Sign_of_the_product_of_an_array();

        [TestMethod()]
        public void ArraySign_Test1()
        {
            // Arrange
            int[] nums = { -1, -2, -3, -4, 3, 2, 1 };
            var expected = 1;

            // Act
            var actual = solution.ArraySign(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ArraySign_Test2()
        {
            // Arrange
            int[] nums = { 1, 5, 0, 2, -3 };
            var expected = 0;

            // Act
            var actual = solution.ArraySign(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ArraySign_Test3()
        {
            // Arrange
            int[] nums = { -1, 1, -1, 1, -1 };
            var expected = -1;

            // Act
            var actual = solution.ArraySign(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}