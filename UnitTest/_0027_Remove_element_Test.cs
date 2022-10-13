using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0027.Remove_element;

namespace _0027.Remove_element.Tests
{
    [TestClass()]
    public class _0027_Remove_element_Test
    {
        _0027_Remove_element solution = new _0027_Remove_element();

        [TestMethod()]
        public void RemoveElement_Test1()
        {
            // Arrange
            int[] nums = { 3, 2, 3, 2 };
            int val = 3;
            var expected = 2;

            // Act
            var actual = solution.RemoveElement(nums, val);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RemoveElement_Test2()
        {
            // Arrange
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;
            var expected = 5;

            // Act
            var actual = solution.RemoveElement(nums, val);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}