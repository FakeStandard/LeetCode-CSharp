using System;
using System.Collections.Generic;

namespace _0145.Binary_tree_postorder_traversal
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
        public IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> res = new List<int>();

            if (root == null) return res;

            PostOrder(root, ref res);

            return res;
        }

        private void PostOrder(TreeNode node, ref IList<int> res)
        {
            if (node != null)
            {
                PostOrder(node.left,ref res);
                PostOrder(node.right, ref res);
                res.Add(node.val);
            }
        }
    }
}
