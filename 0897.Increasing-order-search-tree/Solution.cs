using Common;
using System;

namespace _0897.Increasing_order_search_tree
{
    public class Solution
    {
        private TreeNode res;
        private TreeNode cur;
        public TreeNode IncreasingBST(TreeNode root)
        {
            Find(root);

            return res;
        }

        private void Find(TreeNode node)
        {
            if (node.left != null)
                Find(node.left);

            if (cur == null)
            {
                cur = new TreeNode(node.val);
                res = cur;
            }
            else
            {
                cur.right = new TreeNode(node.val);
                cur = cur.right;
            }

            if (node.right != null)
                Find(node.right);
        }
    }
}
