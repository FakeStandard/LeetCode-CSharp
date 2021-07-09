using System;

namespace Common
{
    /// <summary>
    /// Definition for a binary tree node.
    /// </summary>
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

        public TreeNode AddNode(string[] items)
        {
            TreeNode root = new TreeNode(int.Parse(items[0].ToString()));

            TreeNode current = root;

            for (int i = 1; i < items.Length; i++)
            {
                if (items[i] == null) continue;

                int num = int.Parse(items[i].ToString());

                while (true)
                {
                    if (num < current.val)
                    {
                        if (current.left == null)
                        {
                            current.left = new TreeNode(num);
                            break;
                        }
                        else
                            current = current.left;
                    }
                    else
                    {
                        if (current.right == null)
                        {
                            current.right = new TreeNode(num);
                            break;
                        }
                        else
                            current = current.right;
                    }
                }
            }

            return root;
        }
    }
}
