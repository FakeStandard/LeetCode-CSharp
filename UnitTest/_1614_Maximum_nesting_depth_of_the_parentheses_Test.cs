using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1614.Maximum_nesting_depth_of_the_parentheses;

namespace _1614.Maximum_nesting_depth_of_the_parentheses.Tests
{
    [TestClass()]
    public class _1614_Maximum_nesting_depth_of_the_parentheses_Test
    {
        _1614_Maximum_nesting_depth_of_the_parentheses solution = new _1614_Maximum_nesting_depth_of_the_parentheses();

        [TestMethod()]
        public void MaxDepth_Test1()
        {
            // Arrange
            string s = "(1+(2*3)+((8)/4))+1";
            var expected = 3;

            // Act
            var actual = solution.MaxDepth(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxDepth_Test2()
        {
            // Arrange
            string s = "(1)+((2))+(((3)))";
            var expected = 3;

            // Act
            var actual = solution.MaxDepth(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxDepth_Test3()
        {
            // Arrange
            string s = "1+(2*3)/(2-1)";
            var expected = 1;

            // Act
            var actual = solution.MaxDepth(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxDepth_Test4()
        {
            // Arrange
            string s = "1";
            var expected = 0;

            // Act
            var actual = solution.MaxDepth(s);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}