using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using Solution._1636.Sort_array_by_increasing_frequency;

namespace _1636.Sort_array_by_increasing_frequency.Tests
{
    [TestClass()]
    public class _1636_Sort_array_by_increasing_frequency_Test
    {
        _1636_Sort_array_by_increasing_frequency s = new _1636_Sort_array_by_increasing_frequency();

        [TestMethod()]
        public void FrequencySort_Test1()
        {
            // Arrange
            int[] nums = { 1, 1, 2, 2, 2, 3 };
            int[] expected = { 3, 1, 1, 2, 2, 2 };

            // Act
            var act = s.FrequencySort(nums);

            // Assert
            act.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void FrequencySort_Test2()
        {
            // Arrange
            int[] nums = { 2, 3, 1, 3, 2 };
            int[] expected = { 1, 3, 3, 2, 2 };

            // Act
            var act = s.FrequencySort(nums);

            // Assert
            act.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void FrequencySort_Test3()
        {
            // Arrange
            int[] nums = { -1, 1, -6, 4, 5, -6, 1, 4, 1 };
            int[] expected = { 5, -1, 4, 4, -6, -6, 1, 1, 1 };

            // Act
            var act = s.FrequencySort(nums);

            // Assert
            act.Should().BeEquivalentTo(expected);
        }
    }
}