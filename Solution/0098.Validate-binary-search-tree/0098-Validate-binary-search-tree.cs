using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0098.Validate_binary_search_tree
{
    public class _0098_Validate_binary_search_tree
    {
        public bool IsValidBST(TreeNode root)
        {
            if (root == null) return true;

            return IsValidBST(root, long.MinValue, long.MaxValue);
        }

        public bool IsValidBST(TreeNode root, long min, long max)
        {
            if (root == null) return true;
            if (root.val <= min || root.val >= max) return false;

            return IsValidBST(root.left, min, root.val) && IsValidBST(root.right, root.val, max);
        }
    }
}
