using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0104.Maxium_depth_of_binary_tree;
using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace _0104.Maxium_depth_of_binary_tree.Tests
{
    [TestClass()]
    public class _0104_Maxium_depth_of_binary_tree_Test
    {
        Solution solution = new Solution();

        //[TestMethod()]
        //public void MaxDepth_Test1()
        //{
        //    // Arrange
        //    TreeNode root = AddNode(new string[] { "3", "9", "20", null, null, "15", "7" });
        //    var expected = 3;

        //    // Act
        //    var actual = solution.MaxDepth(root);

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}

        [TestMethod()]
        public void MaxDepth_Test2()
        {
            // Arrange
            TreeNode root = AddNode(new string[] { "1", null, "2" });
            var expected = 2;

            // Act
            var actual = solution.MaxDepth(root);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod()]
        //public void MaxDepth_Test3()
        //{
        //    // Arrange
        //    TreeNode root = new TreeNode();
        //    var expected = 0;

        //    // Act
        //    var actual = solution.MaxDepth(root);

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}

        [TestMethod()]
        public void MaxDepth_Test4()
        {
            // Arrange
            TreeNode root = AddNode(new string[] { "0" });
            var expected = 1;

            // Act
            var actual = solution.MaxDepth(root);

            // Assert
            Assert.AreEqual(expected, actual);
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