using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0238.Product_of_array_except_self;

namespace _0238.Product_of_array_except_self.Tests
{
    [TestClass()]
    public class _0238_Product_of_array_except_self_Test
    {
        _0238_Product_of_array_except_self solution = new _0238_Product_of_array_except_self();

        [TestMethod()]
        public void ProductExceptSelf_Test1()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4 };
            int[] expected = { 24, 12, 8, 6 };

            // Act
            var actual = solution.ProductExceptSelf(nums);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void ProductExceptSelf_Test2()
        {
            // Arrange
            int[] nums = { -1, 1, 0, -3, 3 };
            int[] expected = { 0, 0, 9, 0, 0 };

            // Act
            var actual = solution.ProductExceptSelf(nums);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}