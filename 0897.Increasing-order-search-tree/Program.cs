using System;

namespace _0897.Increasing_order_search_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root;
            TreeNode n1 = new TreeNode(5);
            TreeNode n2 = new TreeNode(3);
            TreeNode n3 = new TreeNode(6);
            TreeNode n4 = new TreeNode(2);
            TreeNode n5 = new TreeNode(4);
            TreeNode n6 = new TreeNode(8);
            TreeNode n7 = new TreeNode(1);
            TreeNode n8 = new TreeNode(7);
            TreeNode n9 = new TreeNode(9);

            root = n1;
            n1.left = n2;
            n1.right = n3;
            n2.left = n4;
            n2.right = n5;
            n4.left = n7;
            n3.right = n6;
            n6.left = n8;
            n6.right = n9;

            Solution s = new Solution();

            s.IncreasingBST(root);

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
        private TreeNode res;
        private TreeNode cur;
        public TreeNode IncreasingBST(TreeNode root)
        {
            Find(root);

            return res;
        }

        private void Find(TreeNode node)
        {
            if (node.left != null)
                Find(node.left);

            if (cur == null)
            {
                cur = new TreeNode(node.val);
                res = cur;
            }
            else
            {
                cur.right = new TreeNode(node.val);
                cur = cur.right;
            }

            if (node.right != null)
                Find(node.right);
        }
    }
}
