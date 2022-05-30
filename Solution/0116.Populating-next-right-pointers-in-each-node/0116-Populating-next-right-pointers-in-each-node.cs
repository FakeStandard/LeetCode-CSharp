using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0116.Populating_next_right_pointers_in_each_node
{
    public class _0116_Populating_next_right_pointers_in_each_node
    {
        public Node Connect(Node root)
        {
            if (root == null) return null;

            Node left = root.left;
            Node right = root.right;

            if (left != null) left.next = right;

            if (right != null && root.next != null)
                right.next = root.next.left;

            Connect(left);
            Connect(right);

            return root;
        }
    }
}
