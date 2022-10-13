using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0167.Two_sum_II_input_array_is_sorted;

namespace _0167.Two_sum_II_input_array_is_sorted.Tests
{
    [TestClass()]
    public class _0167_Two_sum_II_input_array_is_sorted_Test
    {
        _0167_Two_sum_II_input_array_is_sorted solution = new _0167_Two_sum_II_input_array_is_sorted();

        [TestMethod()]
        public void TwoSum_Test1()
        {
            // Arrange
            int[] numbers = { 2, 7, 11, 15 };
            int target = 9;
            var expected = new int[] { 1, 2 };

            // Act
            var actual = solution.TwoSum(numbers, target);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void TwoSum_Test2()
        {
            // Arrange
            int[] numbers = { 2, 3, 4 };
            int target = 6;
            var expected = new int[] { 1, 3 };

            // Act
            var actual = solution.TwoSum(numbers, target);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void TwoSum_Test3()
        {
            // Arrange
            int[] numbers = { -1, 0 };
            int target = -1;
            var expected = new int[] { 1, 2 };

            // Act
            var actual = solution.TwoSum(numbers, target);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}