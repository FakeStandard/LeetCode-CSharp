using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0011.Container_with_most_water;

namespace _0011.Container_with_most_water.Tests
{
    [TestClass()]
    public class _0011_Container_with_most_water_Test
    {
        _0011_Container_with_most_water solution = new _0011_Container_with_most_water();

        [TestMethod()]
        public void MaxArea_Test1()
        {
            // Arrange
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            var expected = 49;

            // Act
            var actual = solution.MaxArea(height);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxArea_Test2()
        {
            // Arrange
            int[] height = { 1, 1 };
            var expected = 1;

            // Act
            var actual = solution.MaxArea(height);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
