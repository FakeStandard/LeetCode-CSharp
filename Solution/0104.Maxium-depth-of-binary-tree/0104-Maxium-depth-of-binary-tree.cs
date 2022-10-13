using Common;

namespace Solution._0104.Maxium_depth_of_binary_tree
{
    public class _0104_Maxium_depth_of_binary_tree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root is null) return 0;

            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);

            return left > right ? left + 1 : right + 1;
        }
    }
}
