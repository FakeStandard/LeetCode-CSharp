using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0105.Construct_binary_tree_from_preorder_and_inorder_traversal
{
    public class _0105_Construct_binary_tree_from_preorder_and_inorder_traversal
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder == null || inorder == null || preorder.Length == 0 || inorder.Length == 0)
                return null;

            return BuildTree(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1);
        }

        private TreeNode BuildTree(int[] preorder, int i, int j, int[] inorder, int m, int n)
        {
            if (i > j || m > n) return null;

            // the first in preorder is root.
            TreeNode node = new TreeNode(preorder[i]);

            if (i != j)
            {
                // Find the same root in inorder.
                int k = m;
                for (; k < inorder.Length; k++)
                    if (inorder[k] == preorder[i])
                        break;

                node.left = BuildTree(preorder, i + 1, i + k - m, inorder, m, k - 1);
                node.right = BuildTree(preorder, i + 1 + k - m, j, inorder, k + 1, n);
            }

            return node;
        }
    }
}
