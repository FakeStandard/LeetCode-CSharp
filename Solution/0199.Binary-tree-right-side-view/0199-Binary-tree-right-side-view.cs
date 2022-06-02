using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0199.Binary_tree_right_side_view
{
    public class _0199_Binary_tree_right_side_view
    {
        private IList<int> _res = new List<int>();
        public IList<int> RightSideView(TreeNode root)
        {
            travel(root, 0);

            return _res;
        }

        private void travel(TreeNode node, int depth)
        {
            if (node == null) return;

            if (depth == _res.Count)
                _res.Add(node.val);

            travel(node.right, depth + 1);
            travel(node.left, depth + 1);
        }
    }
}
