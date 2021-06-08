using System;

namespace _2021_06_08.Construct_binary_tree_from_Preorder_and_Inorder_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] preorder = { 3, 9, 20, 15, 7 };
            int[] inorder = { 9, 3, 15, 20, 7 };

            s.BuildTree(preorder, inorder);

            Console.WriteLine("End");

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
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder == null || inorder == null || preorder.Length == 0 || inorder.Length == 0)
                return null;

            return Build(0, 0, inorder.Length - 1, ref preorder, ref inorder);
        }

        private TreeNode Build(int preStart, int inStart, int inEnd, ref int[] preorder, ref int[] inorder)
        {
            if (inEnd < inStart) return null;

            TreeNode node = new TreeNode(preorder[preStart]);

            int index;

            for (index = inStart; index <= inEnd; index++)
            {
                if (node.val == inorder[index])
                    break;
            }

            if (index > inStart)
                node.left = Build(preStart + 1, inStart, index - 1, ref preorder, ref inorder);

            if (inEnd > index)
                node.right = Build(preStart + index - inStart + 1, index + 1, inEnd, ref preorder, ref inorder);

            return node;
        }
    }
}
