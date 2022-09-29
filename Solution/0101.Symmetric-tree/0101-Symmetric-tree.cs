using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0101.Symmetric_tree
{
    public class _0101_Symmetric_tree
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;

            return Compare(root.left, root.right);
        }

        private bool Compare(TreeNode l, TreeNode r)
        {
            if (l == null && r == null) return true;
            if (l == null || r == null) return false;

            if (l.val == r.val)
                return Compare(l.left, r.right) && Compare(l.right, r.left);

            return false;
        }
    }
}
