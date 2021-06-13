using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1221.Split_a_string_in_balanced_strings;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1221.Split_a_string_in_balanced_strings.Tests
{
    [TestClass()]
    public class _1221_Split_a_string_in_balanced_strings_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void BalancedStringSplit_Test1()
        {
            // Arrange;
            string s = "RLRRLLRLRL";
            var expected = 4;

            // Act
            var actual = solution.BalancedStringSplit(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BalancedStringSplit_Test2()
        {
            // Arrange;
            string s = "RLLLLRRRLR";
            var expected = 3;

            // Act
            var actual = solution.BalancedStringSplit(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BalancedStringSplit_Test3()
        {
            // Arrange;
            string s = "LLLLRRRR";
            var expected = 1;

            // Act
            var actual = solution.BalancedStringSplit(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BalancedStringSplit_Test4()
        {
            // Arrange;
            string s = "RLRRRLLRLL";
            var expected = 2;

            // Act
            var actual = solution.BalancedStringSplit(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}