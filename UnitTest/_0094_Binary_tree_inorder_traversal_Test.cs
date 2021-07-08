using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution._0094.Binary_tree_inorder_traversal;
using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace Solution._0094.Binary_tree_inorder_traversal.Tests
{
    [TestClass()]
    public class _0094_Binary_tree_inorder_traversal_Test
    {
        _0094_Binary_tree_inorder_traversal solution = new _0094_Binary_tree_inorder_traversal();

        [TestMethod()]
        public void InorderTraversal_Test1()
        {
            // Arrange
            TreeNode root = AddNode(new string[] { "1", null, "2", "3" });
            TreeNode expected = AddNode(new string[] { "1", "3", "2" });

            // Act
            var actual = solution.InorderTraversal(root);

            // Assert
            Assert.ReferenceEquals(expected, actual);
        }

        [TestMethod()]
        public void InorderTraversal_Test2()
        {
            // Arrange
            TreeNode root = new TreeNode();
            TreeNode expected = new TreeNode();

            // Act
            var actual = solution.InorderTraversal(root);

            // Assert
            Assert.ReferenceEquals(expected, actual);
        }

        [TestMethod()]
        public void InorderTraversal_Test3()
        {
            // Arrange
            TreeNode root = AddNode(new string[] { "1" });
            TreeNode expected = AddNode(new string[] { "1" });

            // Act
            var actual = solution.InorderTraversal(root);

            // Assert
            Assert.ReferenceEquals(expected, actual);
        }

        [TestMethod()]
        public void InorderTraversal_Test4()
        {
            // Arrange
            TreeNode root = AddNode(new string[] { "1", "2" });
            TreeNode expected = AddNode(new string[] { "2", "1" });

            // Act
            var actual = solution.InorderTraversal(root);

            // Assert
            Assert.ReferenceEquals(expected, actual);
        }

        [TestMethod()]
        public void InorderTraversal_Test5()
        {
            // Arrange
            TreeNode root = AddNode(new string[] { "1", null, "2" });
            TreeNode expected = AddNode(new string[] { "1", "2" });

            // Act
            var actual = solution.InorderTraversal(root);

            // Assert
            Assert.ReferenceEquals(expected, actual);
        }

        private TreeNode AddNode(string[] items)
        {
            TreeNode root = new TreeNode(int.Parse(items[0].ToString()));

            TreeNode current = root;

            for (int i = 1; i < items.Length; i++)
            {
                if (items[i] == null) continue;

                int num = int.Parse(items[i].ToString());

                while (true)
                {
                    if (num < current.val)
                    {
                        if (current.left == null)
                        {
                            current.left = new TreeNode(num);
                            break;
                        }
                        else
                            current = current.left;
                    }
                    else
                    {
                        if (current.right == null)
                        {
                            current.right = new TreeNode(num);
                            break;
                        }
                        else
                            current = current.right;
                    }
                }
            }

            return root;
        }
    }
}