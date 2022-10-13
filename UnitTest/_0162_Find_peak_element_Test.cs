using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0162.Find_peak_element;

namespace _0162.Find_peak_element.Tests
{
    [TestClass()]
    public class _0162_Find_peak_element_Test
    {
        _0162_Find_peak_element solution = new _0162_Find_peak_element();

        [TestMethod()]
        public void FindPeakElement_Test1()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 1 };
            int expected = 2;

            // Act
            var actual = solution.FindPeakElement(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindPeakElement_Test2()
        {
            // Arrange
            int[] nums = { 1, 2, 1, 3, 5, 6, 4 };
            int expected = 1;
            // or other return
            //int expected = 2;

            // Act
            var actual = solution.FindPeakElement(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindPeakElement_Test3()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4 };
            int expected = 3;
            // or other return
            //int expected = 2;

            // Act
            var actual = solution.FindPeakElement(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}