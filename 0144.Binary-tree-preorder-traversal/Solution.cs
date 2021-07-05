using Common;
using System;
using System.Collections.Generic;

namespace _0144.Binary_tree_preorder_traversal
{
    public class Solution
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> res = new List<int>();

            if (root == null) return res;

            PreOrder(root, ref res);

            return res;
        }

        private void PreOrder(TreeNode node, ref IList<int> res)
        {
            if (node != null)
            {
                res.Add(node.val);
                PreOrder(node.left, ref res);
                PreOrder(node.right, ref res);
            }
        }
    }
}
