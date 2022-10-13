using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0704.Binary_search;

namespace _0704.Binary_search.Tests
{
    [TestClass()]
    public class _0704_Binary_search_Test
    {
        _0704_Binary_search solution = new _0704_Binary_search();

        [TestMethod()]
        public void Search_Test1()
        {
            // Arrange
            int[] nums = new int[] { -1, 0, 3, 5, 9, 12 };
            int target = 9;
            int expected = 4;

            // Act
            var actual = solution.Search(nums, target);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Search_Test2()
        {
            // Arrange
            int[] nums = new int[] { -1, 0, 3, 5, 9, 12 };
            int target = 2;
            int expected = -1;

            // Act
            var actual = solution.Search(nums, target);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}