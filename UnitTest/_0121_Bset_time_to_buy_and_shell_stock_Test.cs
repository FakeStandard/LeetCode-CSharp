using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0121.Best_time_to_buy_and_shell_stock;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0121.Best_time_to_buy_and_shell_stock.Tests
{
    [TestClass()]
    public class _0121_Bset_time_to_buy_and_shell_stock_Test
    {
        _0121_Best_time_to_buy_and_shell_stock solution = new _0121_Best_time_to_buy_and_shell_stock();

        [TestMethod()]
        public void MaxProfit_Test1()
        {
            // Arrange
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            var expected = 5;

            // Act
            var actual = solution.MaxProfit(prices);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxProfit_Test2()
        {
            // Arrange
            int[] prices = { 7, 6, 4, 3, 1 };
            var expected = 0;

            // Act
            var actual = solution.MaxProfit(prices);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxProfit_Test3()
        {
            // Arrange
            int[] prices = { 2, 4, 1 };
            var expected = 2;

            // Act
            var actual = solution.MaxProfit(prices);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}