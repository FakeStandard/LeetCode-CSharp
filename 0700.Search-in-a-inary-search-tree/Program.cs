using System;

namespace _0700.Search_in_a_inary_search_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode n1 = new TreeNode(4);
            TreeNode n2 = new TreeNode(2);
            TreeNode n3 = new TreeNode(7);
            TreeNode n4 = new TreeNode(1);
            TreeNode n5 = new TreeNode(3);

            TreeNode node = n1;
            n1.left = n2;
            n1.right = n3;
            n2.left = n4;
            n2.right = n5;

            Solution s = new Solution();
            var root1 = s.SearchBST(node, 5);

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
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null)
                return null;
            else if (root.val == val)
                return root;
            else if (val < root.val)
                return SearchBST(root.left, val);
            else if (val > root.val)
                return SearchBST(root.right, val);
            else
                return null;
        }
    }
}
