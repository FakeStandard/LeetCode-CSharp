using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1827.Minimum_operations_to_make_the_array_increasing;

namespace _1827.Minimum_operations_to_make_the_array_increasing.Tests
{
    [TestClass()]
    public class _1827_Minimum_operations_to_make_the_array_increasing_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void MinOperations_Test1()
        {
            // Arrange
            int[] nums = { 1, 1, 1 };
            var expected = 3;

            // Act
            var actual = solution.MinOperations(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinOperations_Test2()
        {
            // Arrange
            int[] nums = { 1, 5, 2, 4, 1 };
            var expected = 14;

            // Act
            var actual = solution.MinOperations(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinOperations_Test3()
        {
            // Arrange
            int[] nums = { 8 };
            var expected = 0;

            // Act
            var actual = solution.MinOperations(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}