using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0046.Permutations;

namespace _0046.Permutations.Tests
{
    [TestClass()]
    public class _0046_Permutations_Test
    {
        _0046_Permutations solution = new _0046_Permutations();

        [TestMethod()]
        public void Permute_Test1()
        {
            // Arrange
            int[] nums = { 1, 2, 3 };
            var expected = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 1, 3, 2 },
                new int[] { 2, 1, 3 },
                new int[] { 2, 3, 1 },
                new int[] { 3, 1, 2 },
                new int[] { 3, 2, 1 },
            };

            // Act
            var actual = solution.Permute(nums);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void Permute_Test2()
        {
            // Arrange
            int[] nums = { 0, 1 };
            var expected = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 0 },
            };

            // Act
            var actual = solution.Permute(nums);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void Permute_Test3()
        {
            // Arrange
            int[] nums = { 1 };
            var expected = new int[][]
            {
                new int[] { 1 },
            };

            // Act
            var actual = solution.Permute(nums);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}