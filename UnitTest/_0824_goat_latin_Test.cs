using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0824.Goat_latin;

namespace _0824.Goat_latin.Tests
{
    [TestClass()]
    public class _0824_Goat_latin_Test
    {
        _0824_Goat_latin solution = new _0824_Goat_latin();

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