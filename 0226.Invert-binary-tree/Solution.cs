using Common;
using System;

namespace _0226.Invert_binary_tree
{
    public class Solution
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
