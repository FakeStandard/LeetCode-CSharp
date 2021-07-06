using Common;
using System;
using System.Collections.Generic;

namespace _0257.Binary_tree_paths
{
    public class Solution
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            List<string> res = new List<string>();

            if (root == null) return null;

            Path(root, string.Empty, res);

            return res;
        }

        private void Path(TreeNode node, string currentPath, List<string> res)
        {
            currentPath += node.val + "->";

            if (node.left == null && node.right == null)
            {
                res.Add(currentPath.Substring(0, currentPath.Length - 2));
                return;
            }

            if (node.left != null)
                Path(node.left, currentPath, res);
            if (node.right != null)
                Path(node.right, currentPath, res);
        }
    }
}
