using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0169.Majority_element;

namespace _0169.Majority_element.Tests
{
    [TestClass()]
    public class _0169_Majority_element_Test
    {
        _0169_Majority_element solution = new _0169_Majority_element();

        [TestMethod()]
        public void MajorityElement_Test1()
        {
            // Arrange
            int[] nums = { 3, 2, 3 };
            var expected = 3;

            // Act
            var actual = solution.MajorityElement(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MajorityElement_Test2()
        {
            // Arrange
            int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
            var expected = 2;

            // Act
            var actual = solution.MajorityElement(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MajorityElement_Test3()
        {
            // Arrange
            int[] nums = { 1 };
            var expected = 1;

            // Act
            var actual = solution.MajorityElement(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}