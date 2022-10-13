using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0961.N_repeated_element_in_size_2n_array;

namespace _0961.N_repeated_element_in_size_2n_array.Tests
{
    [TestClass()]
    public class _0961_N_repeated_element_in_size_2n_array_Test
    {
        _0961_N_repeated_element_in_size_2n_array solution = new _0961_N_repeated_element_in_size_2n_array();

        [TestMethod()]
        public void RepeatedNTimes_Test1()
        {
            // Arrange
            int[] nums = new int[] { 1, 2, 3, 3 };
            var expected = 3;

            // Act
            var actual = solution.RepeatedNTimes(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RepeatedNTimes_Test2()
        {
            // Arrange
            int[] nums = new int[] { 2, 1, 2, 5, 3, 2 };
            var expected = 2;

            // Act
            var actual = solution.RepeatedNTimes(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RepeatedNTimes_Test3()
        {
            // Arrange
            int[] nums = new int[] { 5, 1, 5, 2, 5, 3, 5, 4 };
            var expected = 5;

            // Act
            var actual = solution.RepeatedNTimes(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}