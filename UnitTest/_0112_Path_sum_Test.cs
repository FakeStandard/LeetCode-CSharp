using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0112.Path_sum;
using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace _0112.Path_sum.Tests
{
    [TestClass()]
    public class _0112_Path_sum_Test
    {
        Solution solution = new Solution();

        //[TestMethod()]
        //public void HasPathSum_Test1()
        //{
        //    // Arrange
        //    TreeNode root = AddNode(new string[] { "5", "4", "8", "11", null, "13", "4", "7", "2", null, null, null, "1" });
        //    int targetSum = 22;

        //    // Act
        //    var actual = solution.HasPathSum(root, targetSum);

        //    // Assert
        //    Assert.IsTrue(actual);
        //}

        [TestMethod()]
        public void HasPathSum_Test2()
        {
            // Arrange
            TreeNode root = AddNode(new string[] { "1", "2", "3" });
            int targetSum = 5;

            // Act
            var actual = solution.HasPathSum(root, targetSum);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void HasPathSum_Test3()
        {
            // Arrange
            TreeNode root = AddNode(new string[] { "1", "2" });
            int targetSum = 0;

            // Act
            var actual = solution.HasPathSum(root, targetSum);

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