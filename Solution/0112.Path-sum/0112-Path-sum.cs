using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0112.Path_sum
{
    public class _0112_Path_sum
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;

            if (root.val == targetSum && root.left == null && root.right == null)
                return true;
            else
                return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);
        }
    }
}
