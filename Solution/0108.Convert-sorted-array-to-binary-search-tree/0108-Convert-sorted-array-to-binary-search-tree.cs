using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0108.Convert_sorted_array_to_binary_search_tree
{
    public class _0108_Convert_sorted_array_to_binary_search_tree
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return null;

            return BuildTree(nums, 0, nums.Length - 1); ;
        }

        private TreeNode BuildTree(int[] nums, int left, int right)
        {
            if (left > right) return null;

            int mid = right + (left - right) / 2;

            TreeNode node = new TreeNode(nums[mid]);

            node.left = BuildTree(nums, left, mid - 1);
            node.right = BuildTree(nums, mid + 1, right);

            return node;
        }
    }
}
