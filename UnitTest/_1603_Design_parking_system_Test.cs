using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Solution._1603.Design_parking_system._1603_Design_parking_system;

namespace _1603.Design_parking_system.Tests
{
    [TestClass()]
    public class _1603_Design_parking_system_Test
    {
        ParkingSystem parkingSystem = new ParkingSystem(1, 1, 0);

        [TestMethod()]
        public void AddCar_Test1()
        {
            // Arrange
            int carType = 1;
            var expected = true;

            // Act
            var actual = parkingSystem.AddCar(carType);

            // Assert
            Assert.AreEqual(expected, actual);

            // Arrange
            carType = 1;
            expected = false;

            // Act
            actual = parkingSystem.AddCar(carType);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddCar_Test2()
        {
            // Arrange
            int carType = 2;
            var expected = true;

            // Act
            var actual = parkingSystem.AddCar(carType);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddCar_Test3()
        {
            // Arrange
            int carType = 3;
            var expected = false;

            // Act
            var actual = parkingSystem.AddCar(carType);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}