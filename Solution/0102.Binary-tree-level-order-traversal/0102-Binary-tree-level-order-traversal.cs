using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0102.Binary_tree_level_order_traversal
{
    public class _0102_Binary_tree_level_order_traversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> res = new List<IList<int>>();

            if (root == null) return res;

            Order(root, res, 0);

            return res;
        }

        private void Order(TreeNode node, List<IList<int>> res, int depth)
        {
            if (node == null) return;

            List<int> list = new List<int>();

            if (res.Count == depth) res.Add(list);
            res[depth].Add(node.val);

            depth++;
            Order(node.left, res, depth);
            Order(node.right, res, depth);
        }
    }
}
