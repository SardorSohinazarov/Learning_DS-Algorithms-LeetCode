using System;

namespace LeetCode.Medium._98
{
    internal class _98
    {
        //private static void Main()
        //{
        //    //[1,null,1]
        //    Solution solution = new Solution();
        //    TreeNode root = new TreeNode(1, null, new TreeNode(1));
        //    Console.WriteLine(solution.IsValidBST(root));
        //}
    }

    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public bool IsValidBST(TreeNode root)
        {
            return dfs(root, null, null);
        }

        public bool dfs(TreeNode root, int? min, int? max)
        {
            if (root == null)
                return true;

            if ((max != null && root.val > max)
                || (min != null && root.val < min))
                return false;

            return dfs(root.left, min, root.val) && dfs(root.right, root.val, max);
        }
    }
}
