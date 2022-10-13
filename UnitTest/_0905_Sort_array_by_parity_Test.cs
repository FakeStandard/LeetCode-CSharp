using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0905.Sort_array_by_parity;

namespace _0905.Sort_array_by_parity.Tests
{
    [TestClass()]
    public class _0905_Sort_array_by_parity_Test
    {
        _0905_Sort_array_by_parity solution = new _0905_Sort_array_by_parity();

        [TestMethod()]
        public void SortArrayByParity_Test1()
        {
            // Arrange
            int[] nums = new int[] { 3, 1, 2, 4 };
            var expected = new int[] { 2, 4, 3, 1 };

            // Act
            var actual = solution.SortArrayByParity(nums);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void SortArrayByParity_Test2()
        {
            // Arrange
            int[] nums = new int[] { 0 };
            var expected = new int[] { 0 };

            // Act
            var actual = solution.SortArrayByParity(nums);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}