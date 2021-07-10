using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solution._0145.Binary_tree_postorder_traversal
{
    public class _0145_Binary_tree_postorder_traversal
    {
        /// <summary>
        /// Iteratively solution
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PostorderTraversal(TreeNode root)
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

                    if (current.left != null)
                        stack.Push(current.left);
                    if (current.right != null)
                        stack.Push(current.right);
                }
            }

            result.Reverse();

            return result;
        }

        /// <summary>
        /// Recursive solution
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        //public IList<int> PostorderTraversal(TreeNode root)
        //{
        //    IList<int> res = new List<int>();

        //    if (root == null) return res;

        //    PostOrder(root, ref res);

        //    return res;
        //}

        //private void PostOrder(TreeNode node, ref IList<int> res)
        //{
        //    if (node != null)
        //    {
        //        PostOrder(node.left, ref res);
        //        PostOrder(node.right, ref res);
        //        res.Add(node.val);
        //    }
        //}
    }
}
