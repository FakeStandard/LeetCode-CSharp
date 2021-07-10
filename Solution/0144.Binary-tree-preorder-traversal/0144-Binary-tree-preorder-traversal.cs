using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0144.Binary_tree_preorder_traversal
{
    public class _0144_Binary_tree_preorder_traversal
    {
        /// <summary>
        /// Iterativeley solution
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();

            if (root == null) return result;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                TreeNode current = stack.Pop();

                if (current != null)
                {
                    result.Add(current.val);
                    stack.Push(current.right);
                    stack.Push(current.left);
                }
            }

            return result;
        }

        /// <summary>
        /// Recursive solution
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        //public IList<int> PreorderTraversal(TreeNode root)
        //{
        //    IList<int> res = new List<int>();

        //    if (root == null) return res;

        //    PreOrder(root, ref res);

        //    return res;
        //}

        //private void PreOrder(TreeNode node, ref IList<int> res)
        //{
        //    if (node != null)
        //    {
        //        res.Add(node.val);
        //        PreOrder(node.left, ref res);
        //        PreOrder(node.right, ref res);
        //    }
        //}
    }
}
