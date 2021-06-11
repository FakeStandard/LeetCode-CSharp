using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1837.Sum_of_digits_in_base_K;

namespace _1837.Sum_of_digits_in_base_K.Tests
{
    [TestClass()]
    public class _1837_Sum_of_digits_in_base_K_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void SumBase_Test1()
        {
            // Arrange
            int n = 34;
            int k = 6;
            var expected = 9;

            // Act
            var actual = solution.SumBase(n, k);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SumBase_Test2()
        {
            // Arrange
            int n = 10;
            int k = 10;
            var expected = 1;

            // Act
            var actual = solution.SumBase(n, k);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}