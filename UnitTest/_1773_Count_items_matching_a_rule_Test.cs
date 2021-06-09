using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1773.Count_items_matching_a_rule;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1773.Count_items_matching_a_rule.Tests
{
    [TestClass()]
    public class _1773_Count_items_matching_a_rule_Test
    {
        Solution s = new Solution();

        [TestMethod()]
        public void CountMatches_Test1()
        {
            IList<IList<string>> items = new List<IList<string>>
            {
                new List<string>{ "phone", "blue", "pixel" },
                new List<string>{ "computer", "silver", "lenovo" },
                new List<string>{ "phone", "gold", "iphone" }
            };
            string ruleKey = "color";
            string ruleValue = "silver";

            // Arrange
            var expected = 1;

            // Act
            var actual = s.CountMatches(items, ruleKey, ruleValue);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountMatches_Test2()
        {
            IList<IList<string>> items = new List<IList<string>>
            {
                new List<string>{ "phone", "blue", "pixel" },
                new List<string>{ "computer","silver","phone" },
                new List<string>{ "phone","gold","iphone" }
            };
            string ruleKey = "type";
            string ruleValue = "phone";

            // Arrange
            var expected = 2;

            // Act
            var actual = s.CountMatches(items, ruleKey, ruleValue);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}