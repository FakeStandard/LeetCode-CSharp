using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0824.Goat_latin;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0824.Goat_latin.Tests
{
    [TestClass()]
    public class _0824_Goat_latin_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void ToGoatLatin_Test1()
        {
            // Arrange
            string sentence = "I speak Goat Latin";
            var expected = "Imaa peaksmaaa oatGmaaaa atinLmaaaaa";

            // Act
            var actual = solution.ToGoatLatin(sentence);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToGoatLatin_Test2()
        {
            // Arrange
            string sentence = "The quick brown fox jumped over the lazy dog";
            var expected = "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa";

            // Act
            var actual = solution.ToGoatLatin(sentence);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}