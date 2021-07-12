using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0917.Reverse_only_letters;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0917.Reverse_only_letters.Tests
{
    [TestClass()]
    public class _0917_Reverse_only_letters_Test
    {
        _0917_Reverse_only_letters solution = new _0917_Reverse_only_letters();

        [TestMethod()]
        public void ReverseOnlyLetters_Test1()
        {
            // Arrange
            string s = "ab-cd";
            var expected = "dc-ba";

            // Act
            var actual = solution.ReverseOnlyLetters(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ReverseOnlyLetters_Test2()
        {
            // Arrange
            string s = "a-bC-dEf-ghIj";
            var expected = "j-Ih-gfE-dCba";

            // Act
            var actual = solution.ReverseOnlyLetters(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ReverseOnlyLetters_Test3()
        {
            // Arrange
            string s = "Test1ng-Leet=code-Q!";
            var expected = "Qedo1ct-eeLg=ntse-T!";

            // Act
            var actual = solution.ReverseOnlyLetters(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}