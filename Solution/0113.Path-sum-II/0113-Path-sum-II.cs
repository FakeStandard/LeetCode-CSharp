using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0113.Path_sum_II
{
    public class _0113_Path_sum_II
    {
        private IList<IList<int>> _res = new List<IList<int>>();
        private List<int> _curr = new List<int>();

        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            if (root == null) return _res;

            travel(root, targetSum);

            return _res;
        }

        private void travel(TreeNode node, int sum)
        {
            if (node == null) return;

            _curr.Add(node.val);

            if (node.val == sum && node.left == null && node.right == null)
                _res.Add(new List<int>(_curr));

            if (node.left != null)
                travel(node.left, sum - node.val);

            if (node.right != null)
                travel(node.right, sum - node.val);

            // delete last item.
            _curr.RemoveAt(_curr.Count - 1);
        }
    }
}
