using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0404.Sum_of_left_leaves
{
    public class _0404_Sum_of_left_leaves
    {
        private int sum = 0;
        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null) return 0;

            if (root.left != null)
            {
                if (root.left.left == null && root.left.right == null)
                    sum += root.left.val;
                else
                    SumOfLeftLeaves(root.left);
            }

            if (root.right != null)
                SumOfLeftLeaves(root.right);

            return sum;
        }
    }
}
