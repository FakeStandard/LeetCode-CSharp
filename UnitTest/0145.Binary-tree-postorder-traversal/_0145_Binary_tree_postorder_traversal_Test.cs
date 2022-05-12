using Common;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0145.Binary_tree_postorder_traversal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0145.Binary_tree_postorder_traversal.Tests
{
    [TestClass()]
    public class _0145_Binary_tree_postorder_traversal_Test
    {
        _0145_Binary_tree_postorder_traversal solution = new _0145_Binary_tree_postorder_traversal();

        [TestMethod()]
        public void PostorderTraversal_Test1()
        {
            // Arrange
            TreeNode root = new TreeNode().AddNode(new string[] { "1", null, "2", "3" });
            var expected = new int[] { 1, 3, 2 };

            // Act
            var actual = solution.PostorderTraversal(root);

            // Assert
            actual.Should().BeEquivalentTo(expected);

        }

        //[TestMethod()]
        //public void PostorderTraversal_Test2()
        //{
        //    // Arrange
        //    TreeNode root = new TreeNode().AddNode(new string[] { });
        //    var expected = new int[] { };

        //    // Act
        //    var actual = solution.PostorderTraversal(root);

        //    // Assert
        //    actual.Should().BeEquivalentTo(expected);
        //}

        [TestMethod()]
        public void PostorderTraversal_Test3()
        {
            // Arrange
            TreeNode root = new TreeNode().AddNode(new string[] { "1" });
            var expected = new int[] { 1 };

            // Act
            var actual = solution.PostorderTraversal(root);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}