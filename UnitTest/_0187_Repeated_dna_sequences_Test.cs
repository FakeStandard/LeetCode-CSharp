using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0187.Repeated_dna_sequences;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0187.Repeated_dna_sequences.Tests
{
    [TestClass()]
    public class _0187_Repeated_dna_sequences_Test
    {
        _0187_Repeated_dna_sequences solution = new _0187_Repeated_dna_sequences();

        [TestMethod()]
        public void FindRepeatedDnaSequences_Test1()
        {
            // Arrange
            string s = "AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT";
            var expected = new List<string>() { "AAAAACCCCC", "CCCCCAAAAA" };

            // Act
            var actual = solution.FindRepeatedDnaSequences(s);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void FindRepeatedDnaSequences_Test2()
        {
            // Arrange
            string s = "AAAAAAAAAAAAA";
            var expected = new List<string>() { "AAAAAAAAAA" };

            // Act
            var actual = solution.FindRepeatedDnaSequences(s);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void FindRepeatedDnaSequences_Test3()
        {
            // Arrange
            string s = "AAAAAAAAAAA";
            var expected = new List<string>() { "AAAAAAAAAA" };

            // Act
            var actual = solution.FindRepeatedDnaSequences(s);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}