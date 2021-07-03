using Common;
using System;

namespace _0112.Path_sum
{
    public class Solution
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
