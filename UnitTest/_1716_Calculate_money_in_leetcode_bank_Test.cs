using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1716.Calculate_money_in_leetcode_bank;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1716.Calculate_money_in_leetcode_bank.Tests
{
    [TestClass()]
    public class _1716_Calculate_money_in_leetcode_bank_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void TotalMoney_Test1()
        {
            // Arrange
            int n = 4;
            var expected = 10;

            // Act
            var actual = solution.TotalMoney(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TotalMoney_Test2()
        {
            // Arrange
            int n = 10;
            var expected = 37;

            // Act
            var actual = solution.TotalMoney(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TotalMoney_Test3()
        {
            // Arrange
            int n = 20;
            var expected = 96;

            // Act
            var actual = solution.TotalMoney(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TotalMoney_Test4()
        {
            // Arrange
            int n = 26;
            var expected = 135;

            // Act
            var actual = solution.TotalMoney(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}