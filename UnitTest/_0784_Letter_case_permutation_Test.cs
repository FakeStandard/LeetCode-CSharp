using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0784.Letter_case_permutation;

namespace _0784.Letter_case_permutation.Tests
{
    [TestClass()]
    public class _0784_Letter_case_permutation_Test
    {
        _0784_Letter_case_permutation solution = new _0784_Letter_case_permutation();

        [TestMethod()]
        public void LetterCasePermutation_Test1()
        {
            // Arrange
            string s = "a1b2";
            var expected = new string[] { "a1b2", "a1B2", "A1b2", "A1B2" };

            // Act
            var actual = solution.LetterCasePermutation(s);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void LetterCasePermutation_Test2()
        {
            // Arrange
            string s = "3z4";
            var expected = new string[] { "3z4", "3Z4" };

            // Act
            var actual = solution.LetterCasePermutation(s);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}