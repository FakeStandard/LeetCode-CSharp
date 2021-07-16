using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1796.Second_largest_digit_in_a_string;

namespace _1796.Second_largest_digit_in_a_string.Tests
{
    [TestClass()]
    public class _1796_Second_largest_digit_in_a_string_Test
    {
        _1796_Second_largest_digit_in_a_string solution = new _1796_Second_largest_digit_in_a_string();

        [TestMethod()]
        public void SecondHighest_Test1()
        {
            // Arrange
            string s = "dfa12321afd";
            var expected = 2;

            // Act
            var actual = solution.SecondHighest(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SecondHighest_Test2()
        {
            // Arrange
            string s = "abc1111";
            var expected = -1;

            // Act
            var actual = solution.SecondHighest(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SecondHighest_Test3()
        {
            // Arrange
            string s = "sjhtz8344";
            var expected = 4;

            // Act
            var actual = solution.SecondHighest(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}