using Common;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0144.Binary_tree_preorder_traversal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0144.Binary_tree_preorder_traversal.Tests
{
    [TestClass()]
    public class _0144_Binary_tree_preorder_traversal_Test
    {
        _0144_Binary_tree_preorder_traversal solution = new _0144_Binary_tree_preorder_traversal();

        [TestMethod()]
        public void PreorderTraversal_Test1()
        {
            // Arrange
            TreeNode root = new TreeNode().AddNode(new string[] { "1", null, "2", "3" });
            var expected = new int[] { 1, 2, 3 };

            // Act
            var actual = solution.PreorderTraversal(root);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        //[TestMethod()]
        //public void PreorderTraversal_Test2()
        //{
        //    // Arrange
        //    TreeNode root = new TreeNode().AddNode(new string[] { });
        //    var expected = new int[] { };

        //    // Act
        //    var actual = solution.PreorderTraversal(root);

        //    // Assert
        //    actual.Should().BeEquivalentTo(expected);
        //}

        [TestMethod()]
        public void PreorderTraversal_Test3()
        {
            // Arrange
            TreeNode root = new TreeNode().AddNode(new string[] { "1" });
            var expected = new int[] { 1 };

            // Act
            var actual = solution.PreorderTraversal(root);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}