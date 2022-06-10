using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0173.Binary_search_tree_iterator
{
    public class _0173_Binary_search_tree_iterator
    {
        public class BSTIterator
        {
            private Stack<TreeNode> stack;

            public BSTIterator(TreeNode root)
            {
                stack = new Stack<TreeNode>();

                TraverseLeft(root);
            }

            public int Next()
            {
                var next = stack.Pop();

                TraverseLeft(next.right);

                return next.val;
            }

            public bool HasNext()
            {
                return stack.Count > 0;
            }

            private void TraverseLeft(TreeNode node)
            {
                while (node != null)
                {
                    stack.Push(node);
                    node = node.left;
                }
            }
        }

        /**
         * Your BSTIterator object will be instantiated and called as such:
         * BSTIterator obj = new BSTIterator(root);
         * int param_1 = obj.Next();
         * bool param_2 = obj.HasNext();
         */
    }
}
