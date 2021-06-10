using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1848.Minimum_distance_to_the_target_element;
namespace _1848.Minimum_distance_to_the_target_element.Tests
{
    [TestClass()]
    public class _1848_Minimum_distance_to_the_target_element_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void GetMinDistance_Test1()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 5 };
            int target = 5;
            int start = 3;
            var expected = 1;

            // Act
            var actual = solution.GetMinDistance(nums, target, start);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetMinDistance_Test2()
        {
            // Arrange
            int[] nums = { 1 };
            int target = 1;
            int start = 0;
            var expected = 0;

            // Act
            var actual = solution.GetMinDistance(nums, target, start);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetMinDistance_Test3()
        {
            // Arrange
            int[] nums = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int target = 1;
            int start = 0;
            var expected = 0;

            // Act
            var actual = solution.GetMinDistance(nums, target, start);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}