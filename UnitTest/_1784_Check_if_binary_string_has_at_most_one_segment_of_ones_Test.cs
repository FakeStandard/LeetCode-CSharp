using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1784.Check_if_binary_string_has_at_most_one_segment_of_ones;

namespace _1784.Check_if_binary_string_has_at_most_one_segment_of_ones.Tests
{
    [TestClass()]
    public class _1784_Check_if_binary_string_has_at_most_one_segment_of_ones_Test
    {
        _1784_Check_if_binary_string_has_at_most_one_segment_of_ones solution = new _1784_Check_if_binary_string_has_at_most_one_segment_of_ones();

        [TestMethod()]
        public void CheckOnesSegment_Test1()
        {
            // Arrange
            string s = "1001";

            // Act
            var actual = solution.CheckOnesSegment(s);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void CheckOnesSegment_Test2()
        {
            // Arrange
            string s = "110";

            // Act
            var actual = solution.CheckOnesSegment(s);

            // Assert
            Assert.IsTrue(actual);
        }
    }
}