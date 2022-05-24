using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0567.Permutation_in_string;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0567.Permutation_in_string.Tests
{
    [TestClass()]
    public class _0567_Permutation_in_string_Test
    {
        _0567_Permutation_in_string solution = new _0567_Permutation_in_string();

        [TestMethod()]
        public void CheckInclusion_Test1()
        {
            // Arrange
            string s1 = "ab";
            string s2 = "eidbaooo";

            // Act
            var actual = solution.CheckInclusion(s1, s2);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void CheckInclusion_Test2()
        {
            // Arrange
            string s1 = "ab";
            string s2 = "eidboaoo";

            // Act
            var actual = solution.CheckInclusion(s1, s2);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void CheckInclusion_Test3()
        {
            // Arrange
            string s1 = "a";
            string s2 = "ab";

            // Act
            var actual = solution.CheckInclusion(s1, s2);

            // Assert
            Assert.IsTrue(actual);
        }
    }
}