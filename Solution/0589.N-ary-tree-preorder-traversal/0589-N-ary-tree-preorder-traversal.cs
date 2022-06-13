using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0589.N_ary_tree_preorder_traversal
{
    public class _0589_N_ary_tree_preorder_traversal
    {
        IList<int> res = new List<int>();
        public IList<int> Preorder(Node root)
        {
            traversal(root);

            return res;
        }

        private void traversal(Node node)
        {
            if (node == null) return;

            res.Add(node.val);

            foreach (var child in node.children)
                traversal(child);
        }
    }

    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}
