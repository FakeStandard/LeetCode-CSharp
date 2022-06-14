using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1022.Sum_of_root_to_leaf_binary_numbers
{
    public class _1022_Sum_of_root_to_leaf_binary_numbers
    {
        public int SumRootToLeaf(TreeNode root)
        {
            int sum = 0;
            traverse(root, 0, ref sum);

            return sum;
        }

        private void traverse(TreeNode node, int current, ref int sum)
        {
            if (node == null) return;

            current *= 2;
            current += node.val;

            if (node.left == null && node.right == null)
            {
                sum += current;
                return;
            }

            traverse(node.left, current, ref sum);
            traverse(node.right, current, ref sum);
        }
    }
}
