using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0771.Jewels_and_stones;

namespace _0771.Jewels_and_stones.Tests
{
    [TestClass()]
    public class _0771_Jewels_and_stones_Test
    {
        _0771_Jewels_and_stones solution = new _0771_Jewels_and_stones();

        [TestMethod()]
        public void NumJewelsInStones_Test1()
        {
            // Arrange
            string jewels = "aA";
            string stones = "aAAbbbb";
            var expected = 3;

            // Act
            var actual = solution.NumJewelsInStones(jewels, stones);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NumJewelsInStones_Test2()
        {
            // Arrange
            string jewels = "z";
            string stones = "ZZ";
            var expected = 0;

            // Act
            var actual = solution.NumJewelsInStones(jewels, stones);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NumJewelsInStones_Test3()
        {
            // Arrange
            string jewels = "aA";
            string stones = "aAAbbbbaabAA";
            var expected = 7;

            // Act
            var actual = solution.NumJewelsInStones(jewels, stones);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}