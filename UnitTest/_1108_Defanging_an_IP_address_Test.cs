using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1108.Defanging_an_IP_address;

namespace _1108.Defanging_an_IP_address.Tests
{
    [TestClass()]
    public class _1108_Defanging_an_IP_address_Test
    {
        _1108_Defanging_an_IP_address solution = new _1108_Defanging_an_IP_address();

        [TestMethod()]
        public void DefangIPaddr_Test1()
        {
            // Arrange
            string address = "1.1.1.1";
            var expected = "1[.]1[.]1[.]1";

            // Act
            var actual = solution.DefangIPaddr(address);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DefangIPaddr_Test2()
        {
            // Arrange
            string address = "255.100.50.0";
            var expected = "255[.]100[.]50[.]0";

            // Act
            var actual = solution.DefangIPaddr(address);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}