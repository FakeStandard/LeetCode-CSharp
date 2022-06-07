using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0236.Lowest_common_ancestor_of_a_binary_tree
{
    public class _0236_Lowest_common_ancestor_of_a_binary_tree
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || root.val == p.val || root.val == q.val) return root;

            var left = LowestCommonAncestor(root.left, p, q);
            var right = LowestCommonAncestor(root.right, p, q);

            if (left != null && right != null)
                return root;

            return left != null ? left : right;
        }
    }
}
