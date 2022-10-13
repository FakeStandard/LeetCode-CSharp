using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._1557.Minimum_number_of_vertices_to_reach_all_nodes;

namespace _1557.Minimum_number_of_vertices_to_reach_all_nodes.Tests
{
    [TestClass()]
    public class _1557_Minimum_number_of_vertices_to_reach_all_nodes_Test
    {
        _1557_Minimum_number_of_vertices_to_reach_all_nodes solution = new _1557_Minimum_number_of_vertices_to_reach_all_nodes();

        [TestMethod()]
        public void FindSmallestSetOfVertices_Test1()
        {
            // Arrange
            int n = 6;
            int[][] edges = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 0, 2 },
                new int[] { 2, 5 },
                new int[] { 3, 4 },
                new int[] { 4, 2 },
            };

            var expected = new int[] { 0, 3 };

            // Act
            var actual = solution.FindSmallestSetOfVertices(n, edges);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void FindSmallestSetOfVertices_Test2()
        {
            // Arrange
            int n = 5;
            int[][] edges = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 2, 1 },
                new int[] { 3, 1 },
                new int[] { 1, 4 },
                new int[] { 2, 4 },
            };

            var expected = new int[] { 0, 2, 3 };

            // Act
            var actual = solution.FindSmallestSetOfVertices(n, edges);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}