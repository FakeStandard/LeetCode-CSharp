using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1880.Check_if_word_equals_summation_of_two_words;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1880.Check_if_word_equals_summation_of_two_words.Tests
{
    [TestClass()]
    public class _1880_Check_if_word_equals_summation_of_two_words_Test
    {
        _1880_Check_if_word_equals_summation_of_two_words s = new _1880_Check_if_word_equals_summation_of_two_words();

        [TestMethod()]
        public void IsSumEqual_Test1()
        {
            // Arrange
            string firstWord = "acb";
            string secondWord = "cba";
            string targetWord = "cdb";

            // Act
            var actual = s.IsSumEqual(firstWord, secondWord, targetWord);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsSumEqual_Test2()
        {
            // Arrange
            string firstWord = "aaa";
            string secondWord = "a";
            string targetWord = "aab";

            // Act
            var actual = s.IsSumEqual(firstWord, secondWord, targetWord);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void IsSumEqual_Test3()
        {
            // Arrange
            string firstWord = "aaa";
            string secondWord = "a";
            string targetWord = "aaaa";

            // Act
            var actual = s.IsSumEqual(firstWord, secondWord, targetWord);

            // Assert
            Assert.IsTrue(actual);
        }
    }
}