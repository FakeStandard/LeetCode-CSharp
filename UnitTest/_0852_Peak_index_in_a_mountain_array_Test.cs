using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0852.Peak_index_in_a_mountain_array;

namespace _0852.Peak_index_in_a_mountain_array.Tests
{
    [TestClass()]
    public class _0852_Peak_index_in_a_mountain_array_Test
    {
        _0852_Peak_index_in_a_mountain_array solution = new _0852_Peak_index_in_a_mountain_array();

        [TestMethod()]
        public void PeakIndexInMountainArray_Test1()
        {
            // Arrange
            int[] arr = { 0, 1, 0 };
            var expected = 1;

            // Act
            var actual = solution.PeakIndexInMountainArray(arr);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PeakIndexInMountainArray_Test2()
        {
            // Arrange
            int[] arr = { 0, 2, 1, 0 };
            var expected = 1;

            // Act
            var actual = solution.PeakIndexInMountainArray(arr);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PeakIndexInMountainArray_Test3()
        {
            // Arrange
            int[] arr = { 0, 10, 5, 2 };
            var expected = 1;

            // Act
            var actual = solution.PeakIndexInMountainArray(arr);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PeakIndexInMountainArray_Test4()
        {
            // Arrange
            int[] arr = { 3, 4, 5, 1 };
            var expected = 2;

            // Act
            var actual = solution.PeakIndexInMountainArray(arr);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PeakIndexInMountainArray_Test5()
        {
            // Arrange
            int[] arr = { 24, 69, 100, 99, 79, 78, 67, 36, 26, 19 };
            var expected = 2;

            // Act
            var actual = solution.PeakIndexInMountainArray(arr);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}