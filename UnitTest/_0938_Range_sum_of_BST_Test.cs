using Microsoft.VisualStudio.TestTools.UnitTesting;
using _0938.Range_sum_of_BST;
using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace _0938.Range_sum_of_BST.Tests
{
    [TestClass()]
    public class _0938_Range_sum_of_BST_Test
    {
        Solution solution = new Solution();

        [TestMethod()]
        public void RangeSumBST_Test1()
        {
            // Arrange
            TreeNode root = AddNode(new string[] { "10", "5", "15", "3", "7", null, "18" });
            int low = 7;
            int high = 15;
            var expected = 32;

            // Act
            var actual = solution.RangeSumBST(root, low, high);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RangeSumBST_Test2()
        {
            // Arrange
            TreeNode root = AddNode(new string[] { "10", "5", "15", "3", "7", "13", "18", "1", null, "6" });
            int low = 6;
            int high = 10;
            var expected = 23;

            // Act
            var actual = solution.RangeSumBST(root, low, high);

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