using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0450.Delete_node_in_a_BST
{
    public class _0450_Delete_node_in_a_BST
    {
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null) return root;

            if (key < root.val)
                root.left = DeleteNode(root.left, key);
            else if (key > root.val)
                root.right = DeleteNode(root.right, key);
            else // root.val == key
            {
                if (root.left == null)
                    return root.right;
                if (root.right == null)
                    return root.left;

                // root.left & root.right != null
                TreeNode node = root.right;

                while (node.left != null)
                    node = node.left;

                root.val = node.val;
                root.right = DeleteNode(root.right, node.val);
            }

            return root;
        }
    }
}
