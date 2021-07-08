using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0100.Same_tree
{
    public class _0100_Same_tree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null || q == null) return p == q;

            if (p.val == q.val)
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);

            return false;
        }
    }
}
