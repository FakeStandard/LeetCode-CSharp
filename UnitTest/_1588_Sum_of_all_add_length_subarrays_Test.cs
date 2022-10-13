using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1588.Sum_of_all_odd_length_subarrays;

namespace _1588.Sum_of_all_odd_length_subarrays.Tests
{
    [TestClass()]
    public class _1588_Sum_of_all_add_length_subarrays_Test
    {
        _1588_Sum_of_all_odd_length_subarrays solution = new _1588_Sum_of_all_odd_length_subarrays();

        [TestMethod()]
        public void SumOddLengthSubarrays_Test1()
        {
            // Arrange
            int[] arr = { 1, 4, 2, 5, 3 };
            var expected = 58;

            // Act
            var actual = solution.SumOddLengthSubarrays(arr);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SumOddLengthSubarrays_Test2()
        {
            // Arrange
            int[] arr = { 1, 2 };
            var expected = 3;

            // Act
            var actual = solution.SumOddLengthSubarrays(arr);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SumOddLengthSubarrays_Test3()
        {
            // Arrange
            int[] arr = { 10, 11, 12 };
            var expected = 66;

            // Act
            var actual = solution.SumOddLengthSubarrays(arr);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}