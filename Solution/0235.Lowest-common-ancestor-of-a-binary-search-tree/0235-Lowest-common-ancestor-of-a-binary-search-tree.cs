using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0235.Lowest_common_ancestor_of_a_binary_search_tree
{
    public class _0235_Lowest_common_ancestor_of_a_binary_search_tree
    {
        /// <summary>
        /// Iterative
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            while (root != null)
            {
                if (root.val > p.val && root.val > q.val)
                    root = root.left;
                else if (root.val < p.val && root.val < q.val)
                    root = root.right;
                else
                    break;
            }

            return root;
        }

        /// <summary>
        /// Recursive
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        //public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        //{
        //    if (root == null) return null;

        //    if (root.val < p.val && root.val < q.val)
        //        return LowestCommonAncestor(root.right, p, q);
        //    else if (root.val > p.val && root.val > q.val)
        //        return LowestCommonAncestor(root.left, p, q);

        //    return root;
        //}
    }
}
