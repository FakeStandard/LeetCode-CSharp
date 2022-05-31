using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._0297.Serialize_and_deserialize_binary_tree
{
    public class _0297_Serialize_and_deserialize_binary_tree
    {
        public class Codec
        {
            // Encodes a tree to a single string.
            public string serialize(TreeNode root)
            {
                if (root == null) return string.Empty;

                List<string> list = new List<string>();
                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(root);

                while (queue.Count > 0)
                {
                    TreeNode curr = queue.Dequeue();
                    list.Add(curr == null ? "" : curr.val.ToString());

                    if (curr != null)
                    {
                        queue.Enqueue(curr.left);
                        queue.Enqueue(curr.right);
                    }
                }

                return string.Join(',', list.ToArray());
            }

            // Decodes your encoded data to tree.
            public TreeNode deserialize(string data)
            {
                if (data == null || data.Length == 0) return null;

                string[] arr = data.Split(',');

                TreeNode root = new TreeNode(int.Parse(arr[0]));
                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(root);

                int i = 1;

                while (i < arr.Length)
                {
                    TreeNode node = queue.Dequeue();

                    if (node != null)
                    {
                        TreeNode leftNode;
                        TreeNode rightNode;

                        // current
                        if (arr[i] == String.Empty)
                            leftNode = null;
                        else
                            leftNode = new TreeNode(int.Parse(arr[i]));

                        // next
                        if (arr[i + 1] == String.Empty)
                            rightNode = null;
                        else
                            rightNode = new TreeNode(int.Parse(arr[i + 1]));

                        // point to node
                        node.left = leftNode;
                        node.right = rightNode;

                        queue.Enqueue(node.left);
                        queue.Enqueue(node.right);

                        i += 2;
                    }
                }

                return root;
            }
        }
    }
}
