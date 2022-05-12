using Common;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0094.Binary_tree_inorder_traversal;
using System;
using System.Collections.Generic;
using System.Text;

namespace _0094.Binary_tree_inorder_traversal.Tests
{
    [TestClass()]
    public class _0094_Binary_tree_inorder_traversal_Test
    {
        _0094_Binary_tree_inorder_traversal solution = new _0094_Binary_tree_inorder_traversal();

        [TestMethod()]
        public void InorderTraversal_Test1()
        {
            // Arrange
            TreeNode root = new TreeNode().AddNode(new string[] { "1", null, "2", "3" });
            var expected = new int[] { 1, 3, 2 };

            // Act
            var actual = solution.InorderTraversal(root);

            // Assert
            actual.Should().BeEquivalentTo(expected);

        }

        //[TestMethod()]
        //public void InorderTraversal_Test2()
        //{
        //    // Arrange
        //    TreeNode root = new TreeNode().AddNode(new string[] { });
        //    var expected = new int[] { };

        //    // Act
        //    var actual = solution.InorderTraversal(root);

        //    // Assert
        //    actual.Should().BeEquivalentTo(expected);
        //}

        [TestMethod()]
        public void InorderTraversal_Test3()
        {
            // Arrange
            TreeNode root = new TreeNode().AddNode(new string[] { "1" });
            var expected = new int[] { 1 };

            // Act
            var actual = solution.InorderTraversal(root);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}