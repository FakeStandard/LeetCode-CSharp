using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0557.Reverse_words_in_a_string_III;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0557.Reverse_words_in_a_string_III.Tests
{
    [TestClass()]
    public class _0557_Reverse_words_in_a_string_III_Test
    {
        _0557_Reverse_words_in_a_string_III solution = new _0557_Reverse_words_in_a_string_III();

        [TestMethod()]
        public void ReverseWords_Test1()
        {
            // Arrange
            string s = "Let's take LeetCode contest";
            string expected = "s'teL ekat edoCteeL tsetnoc";

            // Act
            var actual = solution.ReverseWords(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ReverseWords_Test2()
        {
            // Arrange
            string s = "God Ding";
            string expected = "doG gniD";

            // Act
            var actual = solution.ReverseWords(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}