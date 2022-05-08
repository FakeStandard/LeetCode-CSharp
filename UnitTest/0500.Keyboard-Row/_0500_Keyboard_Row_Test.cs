using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0500.Keyboard_Row;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0500.Keyboard_Row.Tests
{
    [TestClass()]
    public class _0500_Keyboard_Row_Test
    {
        _0500_Keyboard_Row solution = new _0500_Keyboard_Row();

        [TestMethod()]
        public void FindWords_Test1()
        {
            // Arrange
            string[] words = { "Hello", "Alaska", "Dad", "Peace" };
            string[] expacted = { "Alaska", "Dad" };

            // Act
            var actual = solution.FindWords(words);

            // Assert
            actual.Should().BeEquivalentTo(expacted);
        }

        [TestMethod()]
        public void FindWords_Test2()
        {
            // Arrange
            string[] words = { "", };
            string[] expacted = { };

            // Act
            var actual = solution.FindWords(words);

            // Assert
            actual.Should().BeEquivalentTo(expacted);
        }

        [TestMethod()]
        public void FindWords_Test3()
        {
            // Arrange
            string[] words = { "adsdf", "sfd" };
            string[] expacted = { "adsdf", "sfd" };

            // Act
            var actual = solution.FindWords(words);

            // Assert
            actual.Should().BeEquivalentTo(expacted);
        }
    }
}