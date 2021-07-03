using Common;
using System;

namespace _0104.Maxium_depth_of_binary_tree
{
    public class Solution
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);

            return left > right ? left + 1 : right + 1;
        }
    }
}
