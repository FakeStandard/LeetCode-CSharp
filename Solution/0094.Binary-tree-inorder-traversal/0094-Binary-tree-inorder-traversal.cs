﻿using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0094.Binary_tree_inorder_traversal
{
    public class _0094_Binary_tree_inorder_traversal
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
