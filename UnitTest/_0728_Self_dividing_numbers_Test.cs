using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0728.Self_dividing_numbers;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;

namespace _0728.Self_dividing_numbers.Tests
{
    [TestClass()]
    public class _0728_Self_dividing_numbers_Test
    {
        _0728_Self_dividing_numbers solution = new _0728_Self_dividing_numbers();

        [TestMethod()]
        public void SelfDividingNumbers_Test1()
        {
            // Arrange
            int left = 1;
            int right = 22;
            var expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22 };

            // Act
            var actual = solution.SelfDividingNumbers(left, right);

            // Assert
            //Assert.ReferenceEquals(expected, actual);

            // Assert 對參考型別是驗證記憶體位置, 故透過 FluentAssertions 套件來驗證其內容值
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void SelfDividingNumbers_Test2()
        {
            // Arrange
            int left = 47;
            int right = 85;
            var expected = new List<int> { 48, 55, 66, 77 };

            // Act
            var actual = solution.SelfDividingNumbers(left, right);

            // Assert
            //Assert.ReferenceEquals(expected, actual);

            // Assert 對參考型別是驗證記憶體位置, 故透過 FluentAssertions 套件來驗證其內容值
            actual.Should().BeEquivalentTo(expected);
        }
    }
}