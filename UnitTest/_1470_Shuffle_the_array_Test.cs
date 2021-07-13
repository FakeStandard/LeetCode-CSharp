using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using Solution._1470.Shuffle_the_array;

namespace _1470.Shuffle_the_array.Tests
{
    [TestClass()]
    public class _1470_Shuffle_the_array_Test
    {
        _1470_Shuffle_the_array solution = new _1470_Shuffle_the_array();

        [TestMethod()]
        public void Shuffle_Test1()
        {
            // Arrange
            int[] nums = { 2, 5, 1, 3, 4, 7 };
            int n = 3;
            int[] expected = { 2, 3, 5, 4, 1, 7 };

            // Act
            var actual = solution.Shuffle(nums, n);

            // Arrange
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void Shuffle_Test2()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 4, 3, 2, 1 };
            int n = 4;
            int[] expected = { 1, 4, 2, 3, 3, 2, 4, 1 };

            // Act
            var actual = solution.Shuffle(nums, n);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void Shuffle_Test3()
        {
            // Arrange
            int[] nums = { 1, 1, 2, 2 };
            int n = 2;
            int[] expected = { 1, 2, 1, 2 };

            // Act
            var actual = solution.Shuffle(nums, n);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}