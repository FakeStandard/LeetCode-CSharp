using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0101.Symmetric_tree
{
    public class _0101_Symmetric_tree
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;

            return DFS(root.left, root.right);
        }

        private bool DFS(TreeNode left, TreeNode right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null) return false;

            if (left.val == right.val)
                return DFS(left.left, right.right) && DFS(left.right, right.left);

            return false;
        }
    }
}
