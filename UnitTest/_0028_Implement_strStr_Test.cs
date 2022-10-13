using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0028.Implement_strStr;

namespace _0028.Implement_strStr.Tests
{
    [TestClass()]
    public class _0028_Implement_strStr_Test
    {
        _0028_Implement_strStr solution = new _0028_Implement_strStr();

        [TestMethod()]
        public void StrStr_Test1()
        {
            // Arrange
            string haystack = "hello";
            string needle = "ll";
            var expected = 2;

            // Act
            var actual = solution.StrStr(haystack, needle);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void StrStr_Test2()
        {
            // Arrange
            string haystack = "aaaaa";
            string needle = "bba";
            var expected = -1;

            // Act
            var actual = solution.StrStr(haystack, needle);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void StrStr_Test3()
        {
            // Arrange
            string haystack = "";
            string needle = "";
            var expected = 0;

            // Act
            var actual = solution.StrStr(haystack, needle);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}