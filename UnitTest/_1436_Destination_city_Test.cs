using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1436.Destination_city;
using System.Collections.Generic;

namespace _1436.Destination_city.Tests
{
    [TestClass()]
    public class _1436_Destination_city_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void DestCity_Test1()
        {
            // Arrange
            IList<IList<string>> paths = new List<IList<string>>()
            {
                new List<string>{ "London", "New York" },
                new List<string>{ "New York", "Lima" },
                new List<string>{ "Lima", "Sao Paulo" }
            };
            var expected = "Sao Paulo";

            // Act
            var actual = solution.DestCity(paths);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DestCity_Test2()
        {
            // Arrange
            IList<IList<string>> paths = new List<IList<string>>
            {
                new List<string>{ "B", "C" },
                new List<string>{ "D", "B"},
                new List<string>{ "C", "A"}
            };
            var expected = "A";

            // Act
            var actual = solution.DestCity(paths);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DestCity_Test3()
        {
            // Arrange
            IList<IList<string>> paths = new List<IList<string>>
            {
                new List<string>{ "A", "Z" }
            };
            var expected = "Z";

            // Act
            var actual = solution.DestCity(paths);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}