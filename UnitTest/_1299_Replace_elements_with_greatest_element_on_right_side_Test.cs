using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1299.Replace_elements_with_greatest_element_on_right_side;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1299.Replace_elements_with_greatest_element_on_right_side.Tests
{
    [TestClass()]
    public class _1299_Replace_elements_with_greatest_element_on_right_side_Test
    {
        _1299_Replace_elements_with_greatest_element_on_right_side solution = new _1299_Replace_elements_with_greatest_element_on_right_side();

        [TestMethod()]
        public void ReplaceElements_Test1()
        {
            // Arrange
            int[] arr = new int[] { 17, 18, 5, 4, 6, 1 };
            var expected = new int[] { 18, 6, 6, 6, 1, -1 };

            // Act
            var actual = solution.ReplaceElements(arr);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void ReplaceElements_Test2()
        {
            // Arrange
            int[] arr = new int[] { 400 };
            var expected = new int[] { -1 };

            // Act
            var actual = solution.ReplaceElements(arr);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}