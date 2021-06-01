using System;
using System.Collections.Generic;

namespace _0257.Binary_tree_paths
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input: root = [1, 2, 3, null, 5]
            // Output:["1->2->5","1->3"]


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
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            return null;
        }
    }
}
