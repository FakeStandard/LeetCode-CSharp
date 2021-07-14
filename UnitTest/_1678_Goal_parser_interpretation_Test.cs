using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1678.Goal_parser_interpretation;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1678.Goal_parser_interpretation.Tests
{
    [TestClass()]
    public class _1678_Goal_parser_interpretation_Test
    {
        _1678_Goal_parser_interpretation s = new _1678_Goal_parser_interpretation();

        [TestMethod()]
        public void Interpret_Test1()
        {
            // Arrange
            string command = "G()(al)";
            var expected = "Goal";

            // Act
            var actual = s.Interpret(command);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Interpret_Test2()
        {
            // Arrange
            string command = "G()()()()(al)";
            var expected = "Gooooal";

            // Act
            var actual = s.Interpret(command);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Interpret_Test3()
        {
            // Arrange
            string command = "(al)G(al)()()G";
            var expected = "alGalooG";

            // Act
            var actual = s.Interpret(command);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}