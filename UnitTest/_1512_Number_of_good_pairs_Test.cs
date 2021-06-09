using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1512.Number_of_good_pairs;

namespace _1512.Number_of_good_pairs.Tests
{
    [TestClass()]
    public class _1512_Number_of_good_pairs_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void NumIdenticalPairs_Test1()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 1, 1, 3 };
            var expected = 4;

            // Act
            var actual = solution.NumIdenticalPairs(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NumIdenticalPairs_Test2()
        {
            // Arrange
            int[] nums = { 1, 1, 1, 1 };
            var expected = 6;

            // Act
            var actual = solution.NumIdenticalPairs(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NumIdenticalPairs_Test3()
        {
            // Arrange
            int[] nums = { 1, 2, 3 };
            var expected = 0;

            // Act
            var actual = solution.NumIdenticalPairs(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}