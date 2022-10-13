using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1220.Count_vowels_permutation;

namespace _1220.Count_vowels_permutation.Tests
{
    [TestClass()]
    public class _1220_Count_vowels_permutation_Test
    {
        _1220_Count_vowels_permutation solution = new _1220_Count_vowels_permutation();

        [TestMethod()]
        public void CountVowelPermutation_Test1()
        {
            // Arrange
            int n = 1;
            var expected = 5;

            // Act
            var actual = solution.CountVowelPermutation(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountVowelPermutation_Test2()
        {
            // Arrange
            int n = 2;
            var expected = 10;

            // Act
            var actual = solution.CountVowelPermutation(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountVowelPermutation_Test3()
        {
            // Arrange
            int n = 3;
            var expected = 19;

            // Act
            var actual = solution.CountVowelPermutation(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountVowelPermutation_Test4()
        {
            // Arrange
            int n = 4;
            var expected = 35;

            // Act
            var actual = solution.CountVowelPermutation(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountVowelPermutation_Test5()
        {
            // Arrange
            int n = 5;
            var expected = 68;

            // Act
            var actual = solution.CountVowelPermutation(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}