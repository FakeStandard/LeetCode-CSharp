using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0392.Is_subsequence;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0392.Is_subsequence.Tests
{
    [TestClass()]
    public class _0392_Is_subsequence_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void IsSubsequence_Test1()
        {
            // Arrange
            string s = "abc";
            string t = "ahbgdc";

            // Act
            var actual = solution.IsSubsequence(s, t);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsSubsequence_Test2()
        {
            // Arrange
            string s = "axc";
            string t = "ahbgdc";

            // Act
            var actual = solution.IsSubsequence(s, t);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void IsSubsequence_Test3()
        {
            // Arrange
            string s = "";
            string t = "ahbgdc";

            // Act
            var actual = solution.IsSubsequence(s, t);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsSubsequence_Test4()
        {
            // Arrange
            string s = "aaaaaa";
            string t = "bbaaaa";

            // Act
            var actual = solution.IsSubsequence(s, t);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}