using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0226.Invert_binary_tree
{
    public class _0226_Invert_binary_tree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            // DFS
            if (root == null) return root;

            TreeNode invert = root.left;
            root.left = root.right;
            root.right = invert;

            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }
    }
}
