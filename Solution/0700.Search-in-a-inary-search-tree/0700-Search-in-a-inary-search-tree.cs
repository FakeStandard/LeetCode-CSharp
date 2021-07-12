using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0700.Search_in_a_inary_search_tree
{
    public class _0700_Search_in_a_inary_search_tree
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            //if (root == null)
            //    return null;
            //else if (root.val == val)
            //    return root;
            //else if (val < root.val)
            //    return SearchBST(root.left, val);
            //else if (val > root.val)
            //    return SearchBST(root.right, val);
            //else
            //    return null;

            if (root == null)
                return null;

            if (root.val == val)
                return root;

            return val < root.val ? SearchBST(root.left, val) : SearchBST(root.right, val);
        }
    }
}
