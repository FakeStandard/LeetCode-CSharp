using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1047.Remove_all_adjacent_duplicates_in_string;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1047.Remove_all_adjacent_duplicates_in_string.Tests
{
    [TestClass()]
    public class _1047_Remove_all_adjacent_duplicates_in_string_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void RemoveDuplicates_Test1()
        {
            // Arrange
            string s = "abbaca";
            var expected = "ca";

            // Act
            var actual = solution.RemoveDuplicates(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RemoveDuplicates_Test2()
        {
            // Arrange
            string s = "azxxzy";
            var expected = "ay";

            // Act
            var actual = solution.RemoveDuplicates(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}