using System;

namespace _0111.Minimum_depth_of_binary_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            // [3,9,20,null,null,15,7]
            TreeNode n1 = new TreeNode(3);
            TreeNode n2 = new TreeNode(9);
            TreeNode n3 = new TreeNode(20);
            TreeNode n4 = null;
            TreeNode n5 = null;
            TreeNode n6 = new TreeNode(15);
            TreeNode n7 = new TreeNode(7);

            TreeNode root = n1;
            n1.left = n2;
            n1.right = n3;
            n2.left = n4;
            n2.right = n5;
            n3.left = n6;
            n3.right = n7;

            Solution s = new Solution();

            Console.WriteLine(s.MinDepth(root));

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
        public int MinDepth(TreeNode root)
        {
            
        }
    }
}
