using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1313.Decompress_run_length_encoded_list;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;

namespace _1313.Decompress_run_length_encoded_list.Tests
{
    [TestClass()]
    public class _1313_Decompress_run_length_encoded_list_Test
    {
        _1313_Decompress_run_length_encoded_list solution = new _1313_Decompress_run_length_encoded_list();

        [TestMethod()]
        public void DecompressRLElist_Test1()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4 };
            var expected = new int[] { 2, 4, 4, 4 };

            // Act
            var actual = solution.DecompressRLElist(nums);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void DecompressRLElist_Test2()
        {
            // Arrange
            int[] nums = { 1, 1, 2, 3 };
            var expected = new int[] { 1, 3, 3 };

            // Act
            var actual = solution.DecompressRLElist(nums);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}