using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0938.Range_sum_of_BST
{
    public class _0938_Range_sum_of_BST
    {
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root == null) return 0;

            return Traversal(root, low, high);
        }

        private int Traversal(TreeNode node, int low, int high)
        {
            if (node == null) return 0;

            if (node.val < low)
                return Traversal(node.right, low, high);

            if (node.val > high)
                return Traversal(node.left, low, high);

            return node.val + Traversal(node.left, low, high) + Traversal(node.right, low, high);
        }
    }
}
