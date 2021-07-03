using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0100.Same_tree;
using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace _0100.Same_tree.Tests
{
    [TestClass()]
    public class _0100_Same_tree_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void IsSameTree_Test1()
        {
            // Arrange
            TreeNode p = AddNode(new string[] { "1", "2", "3" });
            TreeNode q = AddNode(new string[] { "1", "2", "3" });

            // Act
            var actual = solution.IsSameTree(p, q);

            // Assert
            Assert.IsTrue(actual);
        }

        //[TestMethod()]
        //public void IsSameTree_Test2()
        //{
        //    // Arrange
        //    TreeNode p = AddNode(new string[] { "1", "2" });
        //    TreeNode q = AddNode(new string[] { "1", null, "2" });

        //    // Act
        //    var actual = solution.IsSameTree(p, q);

        //    // Assert
        //    Assert.IsFalse(actual);
        //}

        [TestMethod()]
        public void IsSameTree_Test3()
        {
            // Arrange
            TreeNode p = AddNode(new string[] { "1", "2", "1" });
            TreeNode q = AddNode(new string[] { "1", "1", "2" });

            // Act
            var actual = solution.IsSameTree(p, q);

            // Assert
            Assert.IsFalse(actual);
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