using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0653.Two_sum_IV_input_is_a_BST
{
    public class _0653_Two_sum_IV_input_is_a_BST
    {
        // Approach 2
        public bool FindTarget(TreeNode root, int k)
        {
            if (root == null) return false;

            List<int> bucket = new List<int>();

            return Order(root, k, bucket);
        }

        private bool Order(TreeNode node, int target, List<int> bucket)
        {
            if (node == null) return false;

            if (bucket.Contains(target - node.val)) return true;

            if (!bucket.Contains(node.val)) bucket.Add(node.val);

            return Order(node.left, target, bucket) || Order(node.right, target, bucket);
        }

        // Approach 1
        //public bool FindTarget(TreeNode root, int k)
        //{
        //    if (root == null) return false;

        //    List<int> bucket = new List<int>();

        //    Fill(root, bucket);

        //    List<int> box = new List<int>();
        //    box.Add(bucket[0]);
        //    int diff = 0;

        //    for (int i = 1; i < bucket.Count; i++)
        //    {
        //        diff = k - bucket[i];

        //        if (box.Contains(diff)) return true;
        //        if (!box.Contains(bucket[i])) box.Add(bucket[i]);
        //    }

        //    return false;
        //}

        //private void Fill(TreeNode node, List<int> bucket)
        //{
        //    if (node == null) return;

        //    bucket.Add(node.val);

        //    Fill(node.left, bucket);
        //    Fill(node.right, bucket);
        //}
    }
}
