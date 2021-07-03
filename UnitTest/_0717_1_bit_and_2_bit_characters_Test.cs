using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0717._1_bit_and_2_bit_characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0717._1_bit_and_2_bit_characters.Tests
{
    [TestClass()]
    public class _0717_1_bit_and_2_bit_characters_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void IsOneBitCharacter_Test1()
        {
            // Arrange
            int[] bits = new int[] { 1, 0, 0 };

            // Act
            var actual = solution.IsOneBitCharacter(bits);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsOneBitCharacter_Test2()
        {
            // Arrange
            int[] bits = new int[] { 1, 1, 1, 0 };

            // Act
            var actual = solution.IsOneBitCharacter(bits);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}