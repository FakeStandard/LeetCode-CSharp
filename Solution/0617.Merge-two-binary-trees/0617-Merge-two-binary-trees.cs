using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0617.Merge_two_binary_trees
{
    public class _0617_Merge_two_binary_trees
    {
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
                return null;
            if (root1 == null)
                return root2;
            if (root2 == null)
                return root1;

            root1.val += root2.val;
            root1.left = MergeTrees(root1.left, root2.left);
            root1.right = MergeTrees(root1.right, root2.right);

            return root1;
        }
    }
}
