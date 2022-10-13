using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0205.Isomorphic_strings;

namespace _0205.Isomorphic_strings.Tests
{
    [TestClass()]
    public class _0205_Isomorphic_strings_Test
    {
        _0205_Isomorphic_strings solution = new _0205_Isomorphic_strings();

        [TestMethod()]
        public void IsIsomorphic_Test1()
        {
            // Arrange
            string s = "egg";
            string t = "add";

            // Act
            var actual = solution.IsIsomorphic(s, t);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsIsomorphic_Test2()
        {
            // Arrange
            string s = "foo";
            string t = "bar";

            // Act
            var actual = solution.IsIsomorphic(s, t);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void IsIsomorphic_Test3()
        {
            // Arrange
            string s = "paper";
            string t = "title";

            // Act
            var actual = solution.IsIsomorphic(s, t);

            // Assert
            Assert.IsTrue(actual);
        }
    }
}