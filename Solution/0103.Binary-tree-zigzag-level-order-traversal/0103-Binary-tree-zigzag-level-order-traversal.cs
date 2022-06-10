using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0103.Binary_tree_zigzag_level_order_traversal
{
    public class _0103_Binary_tree_zigzag_level_order_traversal
    {
        private IList<IList<int>> res;
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            res = new List<IList<int>>();

            Traversal(root, 0);

            return res;
        }

        private void Traversal(TreeNode node, int depth)
        {
            if (node == null) return;

            if (depth == res.Count)
                res.Add(new List<int>());

            // even: left->right
            if (depth % 2 == 0)
                res[depth].Add(node.val);
            // odd: right->left
            else
                res[depth].Insert(0, node.val);

            Traversal(node.left, depth + 1);
            Traversal(node.right, depth + 1);
        }
    }
}
