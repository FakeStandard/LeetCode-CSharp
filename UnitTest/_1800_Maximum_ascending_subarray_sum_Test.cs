using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1800.Maximum_ascending_subarray_sum;

namespace _1800.Maximum_ascending_subarray_sum.Tests
{
    [TestClass()]
    public class _1800_Maximum_ascending_subarray_sum_Test
    {
        _1800_Maximum_ascending_subarray_sum solution = new _1800_Maximum_ascending_subarray_sum();

        [TestMethod()]
        public void MaxAscendingSum_Test1()
        {
            // Arrange
            int[] nums = { 10, 20, 30, 5, 10, 50 };
            var expected = 65;

            // Act
            var actual = solution.MaxAscendingSum(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxAscendingSum_Test2()
        {
            // Arrange
            int[] nums = { 10, 20, 30, 40, 50 };
            var expected = 150;

            // Act
            var actual = solution.MaxAscendingSum(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxAscendingSum_Test3()
        {
            // Arrange
            int[] nums = { 12, 17, 15, 13, 10, 11, 12 };
            var expected = 33;

            // Act
            var actual = solution.MaxAscendingSum(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxAscendingSum_Test4()
        {
            // Arrange
            int[] nums = { 100, 10, 1 };
            var expected = 100;

            // Act
            var actual = solution.MaxAscendingSum(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}