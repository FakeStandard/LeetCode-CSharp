using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0049.Group_anagrams;

namespace _0049.Group_anagrams.Tests
{
    [TestClass()]
    public class _0049_Group_anagrams_Test
    {
        _0049_Group_anagrams solution = new _0049_Group_anagrams();

        [TestMethod()]
        public void GroupAnagrams_Test1()
        {
            // Arrange
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
            var expected = new string[][]
            {
                new string[] { "bat" },
                new string[] { "nat", "tan" },
                new string[] { "ate", "eat", "tea" }
            };

            // Act
            var actual = solution.GroupAnagrams(strs);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void GroupAnagrams_Test2()
        {
            // Arrange
            string[] strs = { "" };
            var expected = new string[][]
            {
                new string[] { "" },
            };

            // Act
            var actual = solution.GroupAnagrams(strs);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void GroupAnagrams_Test3()
        {
            // Arrange
            string[] strs = { "a" };
            var expected = new string[][]
            {
                new string[] { "a" },
            };

            // Act
            var actual = solution.GroupAnagrams(strs);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}