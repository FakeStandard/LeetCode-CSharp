using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0230.Kth_smallest_element_in_a_BST
{
    public class _0230_Kth_smallest_element_in_a_BST
    {
        private List<int> bucket;
        private int temp;

        public int KthSmallest(TreeNode root, int k)
        {
            bucket = new List<int>();
            temp = k;

            InOrder(root);

            return bucket[k - 1];
        }

        private void InOrder(TreeNode node)
        {
            if (node == null || bucket.Count >= temp) return;

            InOrder(node.left);
            bucket.Add(node.val);
            InOrder(node.right);
        }
    }
}
