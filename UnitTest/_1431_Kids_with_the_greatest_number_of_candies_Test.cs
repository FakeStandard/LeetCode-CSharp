using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1431.Kids_with_the_greatest_number_of_candies;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;

namespace _1431.Kids_with_the_greatest_number_of_candies.Tests
{
    [TestClass()]
    public class _1431_Kids_with_the_greatest_number_of_candies_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void KidsWithCandies_Test1()
        {
            // Arrange
            int[] candies = { 2, 3, 5, 1, 3 };
            int extraCandies = 3;
            var expected = new List<bool> { true, true, true, false, true };

            // Act
            var actual = solution.KidsWithCandies(candies, extraCandies);

            // Assert
            actual.Should().BeEquivalentTo(expected);

            //Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void KidsWithCandies_Test2()
        {
            // Arrange
            int[] candies = { 4, 2, 1, 1, 2 };
            int extraCandies = 1;
            var expected = new List<bool> { true, false, false, false, false };

            // Act
            var actual = solution.KidsWithCandies(candies, extraCandies);

            // Assert
            actual.Should().BeEquivalentTo(expected);

            //Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void KidsWithCandies_Test3()
        {
            // Arrange
            int[] candies = { 12, 1, 12 };
            int extraCandies = 10;
            var expected = new List<bool> { true, false, true };

            // Act
            var actual = solution.KidsWithCandies(candies, extraCandies);

            // Assert
            actual.Should().BeEquivalentTo(expected);

            //Assert.AreEqual(expected, actual);
        }
    }
}