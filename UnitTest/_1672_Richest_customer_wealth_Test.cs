using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1672.Richest_customer_wealth;

namespace _1672.Richest_customer_wealth.Tests
{
    [TestClass()]
    public class _1672_Richest_customer_wealth_Test
    {
        _1672_Richest_customer_wealth s = new _1672_Richest_customer_wealth();

        [TestMethod()]
        public void MaximumWealth_Test1()
        {
            // Arrange
            int[][] accounts =
        {
                new int[]{ 1,2,3 },
                new int[]{ 3,2,1 }
            };

            var expected = 6;

            // Act
            var actual = s.MaximumWealth(accounts);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaximumWealth_Test2()
        {
            // Arrange
            int[][] accounts =
            {
                new int[]{ 1,5 },
                new int[]{ 7,3 },
                new int[]{ 3,5 }
            };

            var expected = 10;

            // Act
            var actual = s.MaximumWealth(accounts);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaximumWealth_Test3()
        {
            // Arrange
            int[][] accounts =
            {
                new int[]{ 2,8,7 },
                new int[]{ 7,1,3 },
                new int[]{ 1, 9, 5  }
            };

            var expected = 17;

            // Act
            var actual = s.MaximumWealth(accounts);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}