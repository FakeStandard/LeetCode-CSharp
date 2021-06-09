using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using _1720.Decode_XORed_array;

namespace _1720.Decode_XORed_array.Tests
{
    [TestClass()]
    public class _1720_Decode_XORed_array_Test
    {
        Solution s = new Solution();

        [TestMethod()]
        public void Decode_Test1()
        {
            // Arrange
            int[] encoded = { 1, 2, 3 };
            int first = 1;
            int[] expected = { 1, 0, 2, 1 };

            // Act
            var actual = s.Decode(encoded, first);

            // Assert 對參考型別是驗證記憶體位置, 故透過 FluentAssertions 套件來驗證其內容值
            actual.Should().BeEquivalentTo(expected);

            //Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Decode_Test2()
        {
            // Arrange
            int[] encoded = { 6, 2, 7, 3 };
            int first = 4;
            int[] expected = { 4, 2, 0, 7, 4 };

            // Act
            var actual = s.Decode(encoded, first);

            actual.Should().BeEquivalentTo(expected);

            // Assert
            //Assert.AreEqual(expected, actual);
        }
    }
}