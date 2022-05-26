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
            travel(root);

            return _res;
        }

        private void travel(TreeNode node)
        {
            if (node == null) return;

            _res.Add(node.val);

            if (node.right != null)
                travel(node.right);
            else
                travel(node.left);
        }
    }
}
