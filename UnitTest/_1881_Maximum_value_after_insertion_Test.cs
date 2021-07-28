using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1881.Maximum_value_after_insertion;

namespace _1881.Maximum_value_after_insertion.Tests
{
    [TestClass()]
    public class _1881_Maximum_value_after_insertion_Test
    {
        _1881_Maximum_value_after_insertion solution = new _1881_Maximum_value_after_insertion();

        [TestMethod()]
        public void MaxValue_Test1()
        {
            // Arrange
            string n = "99";
            int x = 9;
            var expected = "999";

            // Act
            var actual = solution.MaxValue(n, x);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxValue_Test2()
        {
            // Arrange
            string n = "-13";
            int x = 2;
            var expected = "-123";

            // Act
            var actual = solution.MaxValue(n, x);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxValue_Test3()
        {
            // Arrange
            string n = "753";
            int x = 6;
            var expected = "7653";

            // Act
            var actual = solution.MaxValue(n, x);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}