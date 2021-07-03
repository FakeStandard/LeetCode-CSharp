using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0118.Pascal_s_triangle;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0118.Pascal_s_triangle.Tests
{
    [TestClass()]
    public class _0118_Pascal_s_triangle_Test
    {
        Solution solution = new Solution();

        //[TestMethod()]
        //public void Generate_Test1()
        //{
        //    // Arrange
        //    int numRows = 5;
        //    var expected = new List<List<int>>
        //    {
        //        new List<int>(){1},
        //        new List<int>(){1,1},
        //        new List<int>(){1,2,1},
        //        new List<int>(){1,3,3,1},
        //        new List<int>(){1,4,6,4,1},
        //    };

        //    // Act
        //    var actual = solution.Generate(numRows);

        //    // Assert
        //    Assert.ReferenceEquals(expected, actual);
        //}

        [TestMethod()]
        public void Generate_Test2()
        {
            // Arrange
            int numRows = 1;
            var expected = new List<List<int>>
            {
                new List<int>(){1}
            };

            // Act
            var actual = solution.Generate(numRows);

            // Assert
            Assert.ReferenceEquals(expected, actual);
        }
    }
}