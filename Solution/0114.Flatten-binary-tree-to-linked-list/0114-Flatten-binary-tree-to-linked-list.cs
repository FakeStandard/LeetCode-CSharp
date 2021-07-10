using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0114.Flatten_binary_tree_to_linked_list
{
    public class _0114_Flatten_binary_tree_to_linked_list
    {
        public class Solution
        {
            private List<TreeNode> list = new List<TreeNode>();
            public void Flatten(TreeNode root)
            {
                if (root == null) return;

                PreOrder(root);

                for(int i = 1; i < list.Count; i++)
                {
                    root.left = null;
                    list[i].left = null;
                    root.right = list[i];
                    root = root.right;
                }
            }

            private void PreOrder(TreeNode node)
            {
                if (node == null) return;

                list.Add(node);
                PreOrder(node.left);
                PreOrder(node.right);
            }
        }
    }
}
