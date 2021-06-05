using System;
using System.Collections.Generic;

namespace _0094.Binary_tree_inorder_traversal
{
    class Program
    {
        static void Main(string[] args)
        {
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
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> res = new List<int>();
            Inorder(root, ref res);
            return res;
        }

        private void Inorder(TreeNode node, ref IList<int> res)
        {
            if (node != null)
            {
                Inorder(node.left, ref res);
                res.Add(node.val);
                Inorder(node.right, ref res);
            }
        }
    }
}
