using System;

namespace _0112.Path_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode n1 = new TreeNode(1);
            TreeNode n2 = new TreeNode(2);

            TreeNode root = n1;
            n1.left = n2;

            Solution s = new Solution();
            s.HasPathSum(root, 1);

            Console.ReadLine();
        }
    }

    /**
     * Definition for a binary tree node.
     * public class TreeNode {
     *     public int val;
     *     public TreeNode left;
     *     public TreeNode right;
     *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
     *         this.val = val;
     *         this.left = left;
     *         this.right = right;
     *     }
     * }
     */

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
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
