using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0841.Keys_and_rooms;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0841.Keys_and_rooms.Tests
{
    [TestClass()]
    public class _0841_Keys_and_rooms_Test
    {
        _0841_Keys_and_rooms solution = new _0841_Keys_and_rooms();

        [TestMethod()]
        public void CanVisitAllRooms_Test1()
        {
            // Arrange
            int[][] rooms =
             {
                new int[] { 1 },
                new int[] { 2 },
                new int[] { 3 },
                new int[] {  },
            };

            // Act
            var actual = solution.CanVisitAllRooms(rooms);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void CanVisitAllRooms_Test2()
        {
            // Arrange
            int[][] rooms =
             {
                new int[] { 1, 3 },
                new int[] { 3, 0, 1 },
                new int[] { 2 },
                new int[] { 0 },
            };

            // Act
            var actual = solution.CanVisitAllRooms(rooms);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void CanVisitAllRooms_Test3()
        {
            // Arrange
            int[][] rooms =
             {
                new int[] { 6, 7, 8 },
                new int[] { 5, 4, 9 },
                new int[] {  },
                new int[] { 8 },
                new int[] { 4 },
                new int[] {  },
                new int[] { 1, 9, 2, 3 },
                new int[] { 7 },
                new int[] { 6, 5 },
                new int[] { 2, 3, 1 },
            };

            // Act
            var actual = solution.CanVisitAllRooms(rooms);

            // Assert
            Assert.IsTrue(actual);
        }
    }
}