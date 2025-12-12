using System.Text.Json;

namespace LeetCode.Easy._226
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public TreeNode InvertTree(TreeNode node)
        {
            if (node == null)
                return null;
            else if (node.left == null && node.right == null)
                return node;
            else
            {
                var temp = node.left;
                node.left = node.right;
                node.right = temp;

                node.left = InvertTree(node.left);
                node.right = InvertTree(node.right);

                return node;
            }
        }
    }

    internal class _226
    {
        //public static void Main()
        //{
        //    Solution solution = new Solution();
        //    TreeNode root = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9)));
        //    solution.InvertTree(root);
        //}
    }
}
