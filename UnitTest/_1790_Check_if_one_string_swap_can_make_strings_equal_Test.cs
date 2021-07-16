using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1790.Check_if_one_string_swap_can_make_strings_equal;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1790.Check_if_one_string_swap_can_make_strings_equal.Tests
{
    [TestClass()]
    public class _1790_Check_if_one_string_swap_can_make_strings_equal_Test
    {
        _1790_Check_if_one_string_swap_can_make_strings_equal solution = new _1790_Check_if_one_string_swap_can_make_strings_equal();

        [TestMethod()]
        public void AreAlmostEqual_Test1()
        {
            // Arrange
            string s1 = "bank";
            string s2 = "kanb";

            // Act
            var actual = solution.AreAlmostEqual(s1, s2);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void AreAlmostEqual_Test2()
        {
            // Arrange
            string s1 = "attack";
            string s2 = "defend";

            // Act
            var actual = solution.AreAlmostEqual(s1, s2);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void AreAlmostEqual_Test3()
        {
            // Arrange
            string s1 = "kelb";
            string s2 = "kelb";

            // Act
            var actual = solution.AreAlmostEqual(s1, s2);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void AreAlmostEqual_Test4()
        {
            // Arrange
            string s1 = "abcd";
            string s2 = "dcba";

            // Act
            var actual = solution.AreAlmostEqual(s1, s2);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}