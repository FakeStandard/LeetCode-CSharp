using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0701.Insert_into_a_binary_search_tree
{
    public class _0701_Insert_into_a_binary_search_tree
    {
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null) return root = new TreeNode(val);

            TreeNode curr = root;

            while (curr != null)
            {
                if (curr.val > val)
                {
                    if (curr.left == null)
                    {
                        curr.left = new TreeNode(val);
                        break;
                    }

                    curr = curr.left;
                }
                else
                {
                    if (curr.right == null)
                    {
                        curr.right = new TreeNode(val);
                        break;
                    }

                    curr = curr.right;
                }
            }

            return root;
        }
    }
}
