using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0347.Top_k_frequent_elements;

namespace _0347.Top_k_frequent_elements.Tests
{
    [TestClass()]
    public class _0347_Top_k_frequent_elements_Test
    {
        _0347_Top_k_frequent_elements solution = new _0347_Top_k_frequent_elements();

        [TestMethod()]
        public void TopKFrequent_Test1()
        {
            // Arrange
            int[] nums = new int[] { 1, 1, 1, 2, 2, 3 };
            int k = 2;
            int[] expected = new int[] { 1, 2 };

            // Act
            var actual = solution.TopKFrequent(nums, k);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void TopKFrequent_Test2()
        {
            // Arrange
            int[] nums = new int[] { 1 };
            int[] expected = new int[] { 1 };
            int k = 1;

            // Act
            var actual = solution.TopKFrequent(nums, k);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void TopKFrequent_Test3()
        {
            // Arrange
            int[] nums = new int[] { -1, -1 };
            int[] expected = new int[] { -1 };
            int k = 1;

            // Act
            var actual = solution.TopKFrequent(nums, k);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void TopKFrequent_Test4()
        {
            // Arrange
            int[] nums = new int[] { 3, 0, 1, 0 };
            int[] expected = new int[] { 0 };
            int k = 1;

            // Act
            var actual = solution.TopKFrequent(nums, k);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void TopKFrequent_Test5()
        {
            // Arrange
            int[] nums = new int[] { 4, 1, -1, 2, -1, 2, 3 };
            int[] expected = new int[] { -1, 2 };
            int k = 2;

            // Act
            var actual = solution.TopKFrequent(nums, k);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}